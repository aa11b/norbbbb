using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Megold{
    const int meret = 13;
    static void Z(){
 
        for (int x = 0; x < meret; x++)
        {
            for (int y = 0; y < meret; y++)
            {
                if(x == 0|| x== meret -1|| x+y == meret - 1){
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    static void Iksz(){
        for (int x = 0; x < meret; x++)
        {
            for (int y = 0; y < meret; y++)
            {
                if(x == y|| x+y == meret - 1){
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    static void Csempe(){
        for (int x = 0; x < meret; x++)
        {
            for (int y = 0; y < meret; y++)
            {
                if((x+y)%2==0){
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    static void Celkereszt(){
        for (int x = 0; x < meret; x++)
        {
            for (int y = 0; y < meret; y++)
            {
                if(x==0 || y==0 || y==meret-1 || x==meret-1){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(x>=2 && x<=10 && y==2){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y>=2 && y<=10 && x==2){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(x>=2 && x<=10 && y==10){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y>=2 && y<=10 && x==10){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(x>=4 && x<=8 && y==4){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(x>=4 && x<=8 && y==8){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y>=4 && y<=8 && x==4){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y>=4 && y<=8 && x==8){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(x>=6 && x<=6 && y==6){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else{
                    Console.SetCursorPosition(x,y);
                    Console.Write(" ");
                }
            }
        }
    }
    static void Szamok(){
        for (int x = 0; x < meret; x++)
        {
            for (int y = 0; y < meret; y++){
                 if(x==0 && y<=12){
                    System.Console.Write("1");
                }
                else if(x==2 && y<=12 || x==3 && y<=12){
                    System.Console.Write("2");
                }
                else if(x==5 && y<=12 || x==6 && y<=12 || x==7 && y<=12){
                    System.Console.Write("3");
                }
                else if(x==9 && y<=12 || x==10 && y<=12 || x==11 && y<=12 || x==12 && y<=12){
                    System.Console.Write("4");
                }
            }
            System.Console.WriteLine();
        }
    }
    static void Kigyo(){
        for (int x = 0; x < meret; x++)
        {
            for (int y = 0; y < meret; y++)
            {
                if(y==0){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y>=0 && y<=11 && x==12){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(x>=2 && x<=12 && y==11){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y>=2  && y<=11 && x==2){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(x>=2  && x<=10 && y==2){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y>=2  && y<=11 && x==2){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(x>=4  && x<=10 && y==9){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y>=4  && y<=9 && x==4){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(x>=4  && x<=8 && y==4){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y>=4  && y<=7 && x==8){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(x>=6  && x<=8 && y==7){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==6 && x==6){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y>=2  && y<=9 && x==10){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
               
                else{
                    Console.SetCursorPosition(x,y);
                    Console.Write(" ");
                }
            }
        }
    }
    static void Tabla(){
        for (int x = 0; x < meret; x++)
        {
            for (int y = 0; y < meret; y++)
            {
                if(/*(*/y==0 /*|| y==2 || y==4 || y=6 || y==8 || y==10 || y==12)*/&& (x==0 || x==4 || x==8 || x==12)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(/*(*/y==1/* || y==3 || y==5 || y==7 || y==9 || y==11)*/ && (x==2 || x==6 || x==10)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==2 && (x==0 || x==4 || x==8 || x==12)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==3 && (x==2 || x==6 || x==10)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==4 && (x==0 || x==4 || x==8 || x==12)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==5 && (x==2 || x==6 || x==10)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==6 && (x==0 || x==4 || x==8 || x==12)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==7 && (x==2 || x==6 || x==10)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==8 && (x==0 || x==4 || x==8 || x==12)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==9 && (x==2 || x==6 || x==10)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==10 && (x==0 || x==4 || x==8 || x==12)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==11 && (x==2 || x==6 || x==10)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
                else if(y==12 && (x==0 || x==4 || x==8 || x==12)){
                    Console.SetCursorPosition(x,y);
                    Console.Write("*");
                }
 
                else{
                    Console.SetCursorPosition(x,y);
                    Console.Write(" ");
                }
            }
        }
    }
    static void Betukigyo(){
        for (int x = 0; x < meret; x++)
        {
            for (int y = 0; y < meret; y++)
            {
                if(y==7 && x==7){
                    Console.SetCursorPosition(x,y);
                    Console.Write("A");
                }
                else if(y>=7  && y<=8 && x==8){
                    Console.SetCursorPosition(x,y);
                    Console.Write("B");
                }
                else if(x>=5  && x<=7 && y==8){
                    Console.SetCursorPosition(x,y);
                    Console.Write("C");
                }
                else if(y>=4  && y<=7 && x==5){
                    Console.SetCursorPosition(x,y);
                    Console.Write("D");
                }
                else if(x>=6  && x<=10 && y==4){
                    Console.SetCursorPosition(x,y);
                    Console.Write("E");
                }
                else if(y>=5  && y<=10 && x==10){
                    Console.SetCursorPosition(x,y);
                    Console.Write("F");
                }
                else if(x>=3  && x<=9 && y==10){
                    Console.SetCursorPosition(x,y);
                    Console.Write("G");
                }
                else if(y>=2  && y<=9 && x==3){
                    Console.SetCursorPosition(x,y);
                    Console.Write("H");
                }
                else if(x>=4  && x<=12 && y==2){
                    Console.SetCursorPosition(x,y);
                    Console.Write("I");
                }
                else if(y>=2  && y<=12 && x==12){
                    Console.SetCursorPosition(x,y);
                    Console.Write("J");
                }
                else if(x>=1  && x<=11 && y==12){
                    Console.SetCursorPosition(x,y);
                    Console.Write("K");
                }
                else if(y>=0  && y<=11 && x==1){
                    Console.SetCursorPosition(x,y);
                    Console.Write("L");
                }
               
                else{
                    Console.SetCursorPosition(x,y);
                    Console.Write(" ");
                }
            }
        }
    }
       static void Feltabla(){
        int size = 13;
        for (int i = 0; i < size; i++)
        {
            for (int y = 0; y < size; y++)
            {
                if((y%2==0 && i%2==0||y%2==1 && i%2==1 ) && i+y <= 12){
                    System.Console.Write("*");
                }
                else{
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
    }
    static void Betutegla(){
        int karakter=(int)'A';
       
        for (int x = 1; x < 7; x++)
        {
            for (int y = 1; y < 5; y++)
            {
                Console.SetCursorPosition(x,y);
                Console.Write((char)karakter);
                karakter++;
 
               
                /*if(y==1 && x==1){
                    Console.SetCursorPosition(x,y);
                    Console.Write("A");
                }
                else if(y==2 && x==1){
                    Console.SetCursorPosition(x,y);
                    Console.Write("B");
                }
                else if(y==3 && x==1){
                    Console.SetCursorPosition(x,y);
                    Console.Write("C");
                }
                else if(y==4 && x==1){
                    Console.SetCursorPosition(x,y);
                    Console.Write("D");
                }*/
               
                /*else{
                    Console.SetCursorPosition(x,y);
                    Console.Write(" ");
                }*/
            }
        }
    }    
 
    static void Szamharomszog(){
        int karakter=1;
       
        for (int x = 0; x < meret; x++)
        {
            for (int y = 0; y < meret; y++)
            {
                if(x>=1 && x<=10 && y==11)
                {
                    Console.SetCursorPosition(x,y);
                    Console.Write((char)('0' + karakter %10));
                    karakter++;
                }
                else if(y<=11 && y>=2 && x==11)
                {
                    Console.SetCursorPosition(x,y);
                    Console.Write((char)('0' + karakter %10));
                    karakter++;
                }
                else if(x+y == meret - 1)
                {
                    Console.SetCursorPosition(x,y);
                    Console.Write((char)('0' + karakter %10));
                    karakter++;
                }
            }
        }
    }      
   
    static void Sorok()
    {
        int size = 13;
        Console.SetCursorPosition(0,0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (j - 4== i)
                {
                    Console.SetCursorPosition(j,i);
                    Console.Write('.');
                }
 
            }
            Console.SetCursorPosition(0,i);
        }
        Console.SetCursorPosition(0,0);
        for (int x = 0; x < size; x++)
        {
            for (int k = 0; k < size; k++)
            {
                if (k - 1== x)
                {
                    Console.SetCursorPosition(k,x);
                    Console.Write('.');
                }
            }
            Console.SetCursorPosition(0,x);
        }
 
              for (int x = 0; x < size; x++)
        {
            for (int k = 0; k < size; k++)
            {
                if (x - 2== k)
                {
                    Console.SetCursorPosition(k,x);
                    Console.Write('.');
                }
            }
            Console.SetCursorPosition(2,x);
        }
                      for (int x = 0; x < size; x++)
        {
            for (int k = 0; k < size; k++)
            {
                if (x - 5== k)
                {
                    Console.SetCursorPosition(k,x);
                    Console.Write('.');
                }
            }
            Console.SetCursorPosition(5,x);
        }
    }


    static void szam(){
        int szam = 0;
            for (int x = 0; x < 9; x++)
            {
                System.Console.Write(x);
            }
            for (int y = 0; y < 9; y++)
            {
                System.Console.SetCursorPosition(0,y);
                System.Console.Write(y);
            }

            {
                for (int y = 3; y < 10; y++)
                {
                    System.Console.SetCursorPosition(2,y-1);
                    System.Console.Write(y);
                }

                for (int x = 3; x < 10; x++)
                {
                    System.Console.SetCursorPosition(x-1,2);
                    System.Console.Write(x);
                }

                for (int y = 6; y < 11; y++)
                {
                    System.Console.SetCursorPosition(4,y-2);
                    System.Console.Write(y%10);
                }

                for (int x = 6; x < 11; x++)
                {
                    System.Console.SetCursorPosition(x-2,4);
                    System.Console.Write(x%10);
                }

                for (int y = 9; y < 12; y++)
                {
                    System.Console.SetCursorPosition(6,y-3);
                    System.Console.Write(y%10);
                }

                for (int x = 9; x < 12; x++)
                {
                    System.Console.SetCursorPosition(x-3,6);
                    System.Console.Write(x%10);
                }

                for (int y = 12; y < 13; y++)
                {
                    System.Console.SetCursorPosition(8,y-4);
                    System.Console.Write(y%10);
                }
            }
        }
    
    static void Main(){
        Console.SetWindowSize(20,20);
        //Z();
        //Iksz();
        //Csempe();
        //Celkereszt();
        //Szamok();
        //Kigyo();
        //Tabla();
        //Betukigyo();
        //Feltabla();
        //Betutegla();
        //Szamharomszog();
        //szam();
        Console.ReadKey();
        }
}