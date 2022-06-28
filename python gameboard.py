
import math
import random
import string
import collections
import datetime
import re
import time
import copy



def generateGameBoard(nRows, nCols) :
    if nRows < 10 or nRows > 35 or nCols < 10 or nCols > 35 :
        print("Invalid Input")
    else:
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
def main( ) :
   r,c = 16,29
   iCoords = ["11", "1O", "G1", "GM", "77"]
   ships = ["[CARRIER=>", "[FRG=>", "[BCRUSR=>", "[DSTYR=>", "[SUBM=>"]
   score = 0
   lastMove = ""
   #                       carrier      frigate     submarine   cruiser             destroyer
   #           false miss  hit   false  hit   miss  hit   miss  hit    false  miss  hit   miss
   pCoords = ["AZ", "37", "1A", "CXA", "1O", "99", "79", "AP", "G2",  "  ",  "5K", "GO",  "2B"]

   gBoard = generateGameBoard(r, c)

   gMask = copy.deepcopy(gBoard)

   for i in range(len(iCoords)) :
      gBoard = loadShip(gBoard, r, c, iCoords[i], ships[i])
   for j in pCoords :
      print(checkCoord(r, c, j))

   for j in pCoords :
      print( )
      (gBoard, gMask, score, lastMove) = updateGameBoard(gBoard, gMask, r, c, j, score, lastMove)

if __name__ == "__main__" :
   main( )
