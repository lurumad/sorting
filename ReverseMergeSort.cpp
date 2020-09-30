#include<iostream>
#include <bits/stdc++.h>
using namespace std;
void merge(int a[],int s,int m,int e){
	int n1=m-s+1;
	int n2=e-m;
	int l[n1],r[n2];
	for(int i=0;i<n1;i++){/////0 to middle in left array 
		l[i]=a[s+i];
	}
	for(int i=0;i<n2;i++){///// middle+1 to last in right array
		r[i]=a[m+1+i];
	}
	int i=0,j=0,k=s;
	while(i<n1&&j<n2){
		//////////////////// JUST CHANGE <= TO >= SIGN IT WILL REVERSE 
		if(l[i]>=r[j]){
			a[k]=l[i];
			i++;
		}
		else{
			a[k]=r[j];
			j++;
		}
		k++;
	}
	while(i<n1){
		a[k]=l[i];
		i++;
		k++;
	}
	while(j<n2){
		a[k]=r[j];
		j++;
		k++;
	}
}
void mergeSort(int a[],int s,int e){
	if(s<e){
		int m=s+(e-s)/2;
		mergeSort(a,s,m);
		mergeSort(a,m+1,e);
		merge(a,s,m,e);
	}
}
int main(){
	int n=7;
	int a[7]={10,80,30,90,50,60,70};
	int s=0;
	int e=6;
	int m=(s+e)/2;
	mergeSort(a,s,e);
	for(int i=0;i<n;i++){
		cout<<a[i]<<" ";
	}
	return 0;
}
