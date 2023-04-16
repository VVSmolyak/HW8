string[] input = new string[] {"Cat", "Food", "Twenty", "red", "rotten", "go", "0"};

print(getStrings(input));

string[] getStrings(string[] input) {
    string[] result = new string[input.Length];
    for (int inputIndex = 0, resultIndex = 0; inputIndex<input.Length; inputIndex++) {
        if(input[inputIndex].Length <= 3) {
            result[resultIndex] = input[inputIndex];
            resultIndex++;
        }
    }
    return result;
}

void print(string[] array) {
    string result = "";
    for(int i = 0; i<array.Length; i++) {
        result += array[i]  + " ";
    }

    Console.WriteLine("Result: " + result);
}