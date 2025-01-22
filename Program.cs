/*static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
void Bubbligt(ref int[] arr)
{
    for(int i = 0; i<arr.Length-1; i++){
        for(int j= 0; j<arr.Length-1-i; j++){
            if(arr[j]>arr[j+1]){
                Swap (ref arr[j] , ref arr[j+1]);
            }
        }
    }
}

int[] tal = new int[1000];
Random rng = new Random();
for(int i= 0; i<tal.Length; i++){
    tal[i] = rng.Next(0,1000);
}
    Bubbligt(ref tal);
    foreach(int element in tal){
        Console.Write(element + " ");
    }*/

 

/*using System;




    static void Merge(int[] arr, int l, int m, int r)
    {

        int n1 = m - l + 1;
        int n2 = r - m;


        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;


        for (i = 0; i < n1; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];

 


        i = 0;
        j = 0;


        int k = l;
        while (i < n1 && j < n2) {
            if (L[i] <= R[j]) {
                arr[k] = L[i];
                i++;
            }
            else {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

      
        while (i < n1) {
            arr[k] = L[i];
            i++;
            k++;
        }


        while (j < n2) {
            arr[k] = R[j];
            j++;
            k++;
        }
    }


    static void MergeSort(int[] arr, int l, int r)
    {
        if (l < r) {


            int m = l + (r - l) / 2;


            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);

           
            Merge(arr, l, m, r);
        }
    }

    int[] tal = new int[1000];
    Random rng = new Random();
    for(int i= 0; i<tal.Length; i++){
        tal[i] = rng.Next(0,1000);
        }
            MergeSort(tal, 0, tal.Length-1);
            foreach(int element in tal){
            Console.Write(element + " ");
}*/
