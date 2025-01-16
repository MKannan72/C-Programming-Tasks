#include<stdio.h>

int len(char k[])
{
    int cnt=0;
    
    for(int i=0;k[i]!='\0';i++)
    {
        cnt++;
    }
    return cnt;
}

void main()
{
    char k[50];
    int inc=0,dec=0;
    
    printf("Enter the String : ");
    scanf("%s",k);
    
    int size = len(k);
    
    for(int i=0;i<=size;i++)
    {
        if(k[i]==k[size-1-i])
        {
            inc++;
        }
        else
        {
            dec++;
        }
    }
    
    if(dec==0)
    {
        printf("this is polindrome ");
    }
    else
    {
        printf("This is not polindrome");
    }
}


