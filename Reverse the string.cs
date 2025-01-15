#include<stdio.h>

int size;
char k[50];
char s[10];

int len(char k[])
{
    int cnt=0;
    for(int i=0;k[i]!='\0';i++)
    {
        cnt++;
    }
    return cnt;
}

char reverse(char z[])
{
    for(int i=0;z[i]!='\0';i++)
    {
        s[i]=z[size-1-i];
    }
    prn
}

void main()
{
    
    
    printf("Enter the name : ");
    scanf("%s",k);
    
    size =len(k);
    
    reverse(k);
    
}