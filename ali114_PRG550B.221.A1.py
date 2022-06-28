# Your solution may ONLY use the python modules listed below
# program: a1main.py
# author:  Atson Li
# date:    february 19, 2022
# purpose: python main( ) program for PRG550 Winter 2022 Assignment #1
# version: 1.01 (updated Feb. 15, 2022)

def generateGameBoard(nRows, nCols) :
    if nRows < 10 or nRows > 35 or nCols < 10 or nCols > 35 :
        print("Invalid Input")
    else:
        colString = "  " + string.digits[1:] + string.ascii_uppercase[:nCols-9]
        rowString = string.digits[1:] + string.ascii_uppercase[:nRows-9]
        gameBoard = [['~' for i in range(nCols)] for j in range(nRows)]
    return gameBoard
# end def

def loadShip(boardData, nRows, nCols, coord, ship) :
   rowString = string.digits[1:] + string.ascii_uppercase[:nRows-9]
   colString = string.digits[1:] + string.ascii_uppercase[:nCols-9]
   yValue = rowString.find(coord[0])
   xValue = colString.find(coord[1])
   for i in range(len(ship)) :
      boardData[yValue][xValue + i] = ship[i]
   return boardData
# end def

def checkCoord(nRows, nCols, coord) :
    rowString = string.digits[1:] + string.ascii_uppercase[:nRows-9]
    colString = string.digits[1:] + string.ascii_uppercase[:nCols-9]
    if coord == "  " or len(coord) != 2:
        return False
    else:
        if rowString.find(coord[0])!= -1 and colString.find(coord[1])!= -1:
            return True
        else:
            return False
# end def

def updateGameBoard(boardData, boardMask, nRows, nCols, coord, score, lastMove) :
    hit=''
    ship=""
    rowString = string.digits[1:] + string.ascii_uppercase[:nRows-9]
    colString = string.digits[1:] + string.ascii_uppercase[:nCols-9]
    yValue = rowString.find(coord[0])
    xValue = colString.find(coord[1])
    if checkCoord(nRows, nCols, coord) == True:
        if boardData[yValue][xValue] != "~" and boardData[yValue][xValue] != "X" and boardMask[yValue][xValue] == "~":
            hit = boardData[yValue][xValue]
            i = 0
            while boardData[yValue][xValue - i] !="~" and xValue - i >=0:
                ship = boardData[yValue][xValue - i] + ship
                i+=1
            j = 1
            while xValue + j < nCols:
                if  boardData[yValue][xValue + j] !="~":
                    ship += boardData[yValue][xValue + j] 
                    j+=1
                else:
                    break
            for k in range(len(ship)) :
                boardMask[yValue][xValue -i + 1 + k] = ship[k]
            score += 5 * len(ship)
            lastMove = "Torpedo HIT "+ "'" + hit + "'" " at " +"[" + coord[0]+ "," + coord[1] + "]"
            print("  Python Battleship@Seneca...")
            print(" ", colString)
            for i in range(nRows) :
                print(rowString[i] + "|", end="")
                for j in range(nCols) :
                    print(boardMask[i][j], end="")
                print("|")
            print("Current Score:" + f'{score:03d}',  "Last Move:", lastMove)
        else:
            hit='X'
            lastMove= "Torpedo MISS at " + "[" + coord[0]+ "," + coord[1] + "]"
            boardMask[yValue][xValue] = hit
            print("  Python Battleship@Seneca...")
            print(" ", colString)
            for i in range(nRows) :
                print(rowString[i] + "|", end="")
                for j in range(nCols) :
                    print(boardMask[i][j], end="")
                print("|")
            print("Current Score:" + f'{score:03d}',  "Last Move:", lastMove)
    else:
        lastMove ="[" + coord[0]+ "," + coord[1] + "]" + " is an INVALID COORDINATE"
        print("  Python Battleship@Seneca...")
        print(" ", colString)
        for i in range(nRows) :
            print(rowString[i] + "|", end="")
            for j in range(nCols) :
                print(boardMask[i][j], end="")
            print("|")
        print("Current Score:" + f'{score:03d}',  "Last Move:", lastMove)
    return boardData, boardMask,score, lastMove
#end def