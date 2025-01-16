#include<stdio.h>

void main()
{
    int num,reverse=0;
    
    printf("Enter the number : ");
    scanf("%d",&num);
    
    int originalnum = num;
    
    
    while(num!=0)
    {
        int remainder = num%10;
        reverse = reverse*10+remainder;
        num = num/10;
    }
    
    if(originalnum==reverse)
    {
        printf("this is polindrome number ");
    }
    else
    {
        printf("This is not polindrome number ");
    }
}