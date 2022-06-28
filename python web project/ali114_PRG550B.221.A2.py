#!/home/pi/software/bin/python3

import cgi, cgitb
import xlsxwriter
import re
import datetime
from xlsxwriter.utility import xl_rowcol_to_cell
from xlsxwriter.utility import xl_range


cgitb.enable( )  
form = cgi.FieldStorage( )

#get all the values

courseName   = form.getvalue('text')
quizNum   = form.getvalue('quizNum')
quizVal    = form.getvalue('quizVal')
labNum   = form.getvalue('labNum')
labVal= form.getvalue('labVal')
assignmentNum   = form.getvalue('assignmentNum')
assignmentVal= form.getvalue('assignmentVal')
testNum   = form.getvalue('testNum')
testVal= form.getvalue('testVal')
bgcolor= form.getvalue('bgcolor')

#check course name

if courseName != None:
        match = re.search(r'\b[a-zA-Z]{3}\d{3}\b', courseName)
        if match:
                courseCheck= True
        else:
                courseCheck= False
else:
        courseCheck=False
        
#check total value
        
checkTotal=False
quizSum = int(quizNum) * int(quizVal.strip('%'))
labSum = int(labNum) * int(labVal.strip('%'))
assignmentSum = int(assignmentNum) * int(assignmentVal.strip('%'))
testSum = int(testNum) * int(testVal.strip('%'))
total = quizSum+labSum+assignmentSum+testSum
if total == 100:
        checkTotal= True
else:
        checkTotal= False

quiz=['Q1','Q2','Q3','Q4']
lab=['L1','L2','L3','L4','L5','L6','L7','L8',]
assignment=['A1','A2','A3','A4']
test=['T1','T2']



#create a xlsx file

date1 = datetime.date.today()
date1 = date1.strftime("%Y.%m.%d")
workbook = xlsxwriter.Workbook('%s.%s.xlsx'%(courseName.lower(),date1))
worksheet = workbook.add_worksheet( )
worksheet.set_column('A:A', 10)
worksheet.write('A1', 'Student #')
worksheet.set_column('B:B', 25)
worksheet.write('B1', 'Last')
worksheet.set_column('C:C', 15)
worksheet.write('C1', 'First')
worksheet.set_column('D:D', 10)
worksheet.write('D1', 'Login')

#read file data.dat and input into xlsx file
try:
        fh = open('data.dat', "r", encoding = 'utf-8')
except IOError:
        print("error opening file... " + fileName)
else:
        rowCount=1
        for line in fh.readlines():
                studentInfo = line.split(';')
                for i in range(0,4):
                        worksheet.write(rowCount,i,studentInfo[i])
                rowCount+=1
                    
fh.close( )
worksheet.insert_image(rowCount,0, 'python.png')

cell_format = workbook.add_format()
cell_format.set_pattern(1) 
cell_format.set_bg_color(bgcolor)

#input headings of marking system
marking={}
marking['quiz']=quiz[0:int(quizNum)]
marking['lab']=lab[0:int(labNum)]
marking['assignment']=assignment[0:int(assignmentNum)]
marking['test']=test[0:int(testNum)]
quizColumn=4
for x in range (0,int(quizNum)):
        worksheet.write(0, quizColumn, marking['quiz'][x],cell_format)
        quizColumn+=1
        
labColumn=quizColumn
for y in range (0,int(labNum)):
        worksheet.write(0, labColumn, marking['lab'][y],cell_format)
        labColumn+=1
        
assignmentColumn=labColumn
for z in range (0,int(assignmentNum)):
        worksheet.write(0, assignmentColumn, marking['assignment'][z],cell_format)
        assignmentColumn+=1

testColumn=assignmentColumn
for n in range (0,int(testNum)):
        worksheet.write(0, testColumn, marking['test'][n],cell_format)
        testColumn+=1
worksheet.write(0, testColumn, 'Score',cell_format)
worksheet.write(0, testColumn + 1, 'Grade',cell_format)

#calculate grades of each student
markingValue=[]
markingValue+=[str(int(quizVal.strip('%'))/100)]*int(quizNum)
markingValue+=[str(int(labVal.strip('%'))/100)]*int(labNum)
markingValue+=[str(int(assignmentVal.strip('%'))/100)]*int(assignmentNum)
markingValue+=[str(int(testVal.strip('%'))/100)]*int(testNum)

for count,value in enumerate(markingValue):
        worksheet.write(rowCount, 4 + count, value)

for k in range (1,rowCount):
        scoreRange = xl_range(k, 4, k, testColumn-1)
        weightRange = xl_range(rowCount, 4 , rowCount, 4 +len(markingValue)-1)
        worksheet.write_formula(k,testColumn, '{=SUM(%s*%s)}'%(scoreRange,weightRange))
 

for m in range (1,rowCount):
        cell = xl_rowcol_to_cell(m, testColumn)
        worksheet.write_formula(m,testColumn +1, '=IF(%s<55,"F",IF(%s<60,"D",IF(%s<70,"C",IF(%s<80,"B",IF(%s<95,"A","A+")))))'%(cell,cell,cell,cell,cell))
workbook.close( )

#get date and time for output
date2 = datetime.datetime.now()
date2 = date2.strftime("%B %d,%Y at %I:%M %p")
#print out on the html page

print("Content-type: text/html\n\n")
print("<html>\n")
print("<head>\n")
print("<title>Python CGI Program</title>\n")
print("</head>\n")
print("<pre>\n")
if courseCheck:
        if checkTotal==True:
                print('Spreadsheet %s.%s.xlsx created on %s.'%(courseName.lower(),date1,date2))
                print('Spreadsheet contains:')
                print()
                if quizNum!=0:
                        print(quizNum,"quizzes @", quizVal, "each")
                if labNum!=0:
                        print(labNum,"labs @", labVal, "each")
                if assignmentNum!=0:
                        print(assignmentNum,"assignments @", assignmentVal, "each")
                if testNum!=0:
                        print(testNum,"tests @", testVal, "each")
                print("TOTAL 100%")
        else:
                print("Marking system must be 100% in total!")
                print("Please go back!!")
else:
        print("Course name is not correct! It must be the first 3 characters being letters and the last 3 numbers!(eg.)PRG550")
        print("Please go back!!")


print("</pre>\n")
print("</body>\n")
print("</html>\n")
