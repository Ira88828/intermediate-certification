{
  
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };
        ReverseArray(array, array.Length - 1);
    }

     void ReverseArray(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            ReverseArray(array, index - 1);
        }
    }
}
