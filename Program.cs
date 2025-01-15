static void Swap(ref int a, ref int b)
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
static void Main()
{
    int[] tal = new int[1000];
    Random rng = new Random();
    for(int i= 0; i<tal.Length; i++)
        tal[i] = rng.Next(0,1000);
}