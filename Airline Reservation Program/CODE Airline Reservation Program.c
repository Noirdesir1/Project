#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include<string.h>
#define N 100
struct seatinfo {
	char status;
	char fname[N], lname[N];
	int seatnum;
}seatassign[12];

int i, count;

int main() {

	char selection;
	int num;
    FILE* seat;
	const char empty[] = "EMPTY";
	const char seats[] = "SEAT";
	printf("This is a flight seat reservation parogram, Hit anykey to see the Menu.\n");
	system("pause");
	system("cls");

	do{
		printf("\t\tEcono-Flight Airline Reservation Program\n");
		printf("a.\tDisplay ALL seat assignments(including Empty).\n");
		printf("b.\tShow ONLY a list of empty seatsand show total of empty seats.\n");
		printf("c.\tShow ONLY the assigned seats with name of personand total assigned.\n");
		printf("d.\tAssign the customer to an empty seat.\n");
		printf("e.\tDelete ONE seat assignment.\n");
		printf("f.\tDelete ALL seat assignments.\n");
		printf("q.\tQuit program.\n");
		printf("Enter your selection.\n");
		scanf("%c", &selection);
		system("cls");
		switch (selection){
			case 'a':
			case 'A':
				printf("\t\t\tSeating Arrangement\n\n");
				printf("\tSeat#\t\tStatus\t\tLast Name\tFirst Name\n\n");
				if ((seat = fopen("seat.bin", "rb")) != NULL) {
					fread(seatassign, sizeof(struct seatinfo), 12, seat);
					for (i = 0; i < 12; i++) {
						printf("\t%d\t\t%c\t\t%s\t\t%s\n", seatassign[i].seatnum, seatassign[i].status, seatassign[i].lname, seatassign[i].fname);
					}
				}
				else {
					seat = fopen("seat.bin", "wb");
						for (i = 0; i < 12; i++) {
							seatassign[i].seatnum = i + 1;
							seatassign[i].status = 'n';
							strcpy(seatassign[i].lname, empty);
							strcpy(seatassign[i].fname, seats);
							printf("\t%d\t\t%c\t\t%s\t\t%s\n", seatassign[i].seatnum, seatassign[i].status, seatassign[i].lname, seatassign[i].fname);
						}
						for(i=0;i<12;i++)
                        {
                            fwrite(&seatassign[i],sizeof(struct seatinfo),1,seat);
                        }
	
				}
				for (i = 0, count = 0; i < 12; i++) {
					if (seatassign[i].status == 'n')
						count++;
				}
				printf("\nThere are %d empty seats\n\n", count);
				fclose(seat);
				system("pause");
				system("cls");
			break;

			case 'B':
			case 'b':
				printf("\t\t\tSeating Arrangement\n\n");
				printf("\tSeat#\t\tStatus\t\tLast Name\tFirst Name\n\n");
				if ((seat = fopen("seat.bin", "rb")) != NULL) {

				fread(seatassign, sizeof(struct seatinfo), 12, seat);
					for (i = 0, count = 0; i < 12; i++) {
						if (seatassign[i].status == 'n') {
							count++;
							printf("\t%d\t\t%c\t\t%s\t\t%s\n", seatassign[i].seatnum, seatassign[i].status, seatassign[i].lname, seatassign[i].fname);
						}
					}
				}
				printf("\nThere are %d EMPTY seats\n\n", count);
				fclose(seat);
				system("pause");
				system("cls");
			break;
			case 'C':
			case 'c':
				printf("\t\t\tSeating Arrangement\n\n");
				printf("\tSeat#\t\tStatus\t\tLast Name\tFirst Name\n\n");
				if ((seat = fopen("seat.bin", "rb")) != NULL) {

					fread(seatassign, sizeof(struct seatinfo), 12, seat);
					for (i = 0, count = 0; i < 12; i++) {
						if (seatassign[i].status == 'y') {
							count++;
							printf("\t%d\t\t%c\t\t%s\t\t%s\n", seatassign[i].seatnum, seatassign[i].status, seatassign[i].lname, seatassign[i].fname);
						}
					}
				}
				printf("\nThere are %d ASSIGNED Seats\n\n", count);
				fclose(seat);
				system("pause");
				system("cls");

			break;

			case 'D':
			case 'd':

				printf("\t The following seats are available -\n\n");

				if ((seat = fopen("seat.bin", "rb")) != NULL) {

					fread(seatassign, sizeof(struct seatinfo), 12, seat);
					for (i = 0, count = 0; i < 12; i++) {
						if (seatassign[i].status == 'n') {
							count++;
							printf("\t\t%d\n", seatassign[i].seatnum);
						}
					}
				}
				printf("\nThere are %d EMPTY Seats\n\n", count);
				printf("\nWhich Seat would you like (0 to exit)?\n\n");


					scanf("%d", &num);
					if(num != 0) {

						if ((seat = fopen("seat.bin", "rb+")) != NULL) {
							fread(seatassign, sizeof(struct seatinfo), 12, seat);
							printf("\nInput Last Name?");
							char lname[N];
							char fname[N];
							scanf("%s", lname);
							strcpy(seatassign[num - 1].lname, lname);
							printf("\nInput First Name?");
							scanf("%s", fname);
							strcpy(seatassign[num - 1].fname, fname);

							seatassign[num - 1].status = 'y';
							fseek(seat, 0, SEEK_SET);
							fwrite(seatassign, sizeof(struct seatinfo), N, seat);
							
						}
						break;
					}
					fclose(seat);
					system("pause");
					system("cls");

			break;
			case 'E':
			case 'e':
				printf("\tHere are the seats you can delete\n\n");
				seat = fopen("seat.bin", "r+");
				if ((seat = fopen("seat.bin", "rb")) != NULL) {

					fread(seatassign, sizeof(struct seatinfo), N, seat);
					for (i = 0; i < 12; i++) {
						if (seatassign[i].status == 'y') {

							printf("\t%d\t\t%s\t\t%s\n", seatassign[i].seatnum, seatassign[i].lname, seatassign[i].fname);
						}
					}
				}

				printf("\tWhich Seat would you like to delete (0 to exit)?\n\n");
				scanf("%d", &num);
				while (num != 0) {
					if ((seat = fopen("seat.bin", "rb+")) != NULL) {
						fread(seatassign, sizeof(struct seatinfo), N, seat);

						strcpy(seatassign[num - 1].lname, empty);

						strcpy(seatassign[num - 1].fname, seats);

						seatassign[num - 1].status = 'n';
						fwrite(seatassign, sizeof(struct seatinfo), N, seat);
					}
					break;
				}
				fclose(seat);
				system("pause");
				system("cls");

			break;
			case 'F':
			case 'f':

				printf("Are you sure you want to RESET the DATA (y/n)?");
				char dic;
				scanf(" %c", &dic);
				if (dic == 'y') {
					seat = fopen("seat.bin", "wb");
					for (i = 0; i < 12; i++) {
						seatassign[i].seatnum = i + 1;
						seatassign[i].status = 'n';
						strcpy(seatassign[i].lname, empty);
						strcpy(seatassign[i].fname, seats);
					}
					for (i = 0; i < 12; i++)
					{
						fwrite(&seatassign[i], sizeof(struct seatinfo), 1, seat);
					}
				}
				else {
					break;
				}
				fclose(seat);
				system("pause");
				system("cls");
                break;
		}

	} while (selection != 'q' && selection != 'Q');
	return 0;

}
