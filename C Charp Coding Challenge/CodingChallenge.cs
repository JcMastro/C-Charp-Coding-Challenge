public class CodingChallenge
{
    static void Main(string[] args)
    {

    }
    public string OldPhonePad(string input)//Method definition
    {
        string output;//ouput parameter definition

        List<int> numbersList = splitInput(input);//Call method to split the input in segments
        List<string> charactersList = convertToCharacters(numbersList);//Call method to convert numbers segments in characters

        output = string.Join("", charactersList);//Join all letters in a single text

        return output;
    }
    public List<int> splitInput(string input)
    {
        List<int> result = new List<int>();//output parameter definition
        string segment = "";
        for (int i = 0; i < input.Length; i++)//Loop through the chain
        {
            if (i == 0)//First case, add first element on the input to the segment 
            {
                segment += input[i];
            }
            else if (input[i] == input[i - 1])//Second case, compare current element with the previous one
            {
                segment += input[i];
            }
            else if (input[i] == '*')//Third case, search for * on the input to delete the previus element
            {
                segment = segment.Substring(0, segment.Length - 1);
            }
            else if (i == input.Length)//Fourth case, search for the last element
            {
                result.Add(int.Parse(input[i].ToString()));
            }
            else if (input[i] == ' ')//Fifth case, search for blanc between the numbers in the input
            {
                //Skips on blanc
            }
            else
            {
                result.Add(int.Parse(segment));//add number segment to the result list
                segment = input[i].ToString();//set segment with the next valid element on the input
            }
        }

        return result;
    }
    public List<string> convertToCharacters(List<int> numbersList)
    {
        List<string> characters = new List<string>();//output parameter definition

        for (int i = 0; i < numbersList.Count; i++)//Loop trought numbersList
        {
            characters.Add(GetLetter(numbersList[i]));//Convert the numbers and add the letters 
        }

        return characters;
    }

    public String GetLetter(int number)
    {
        String letter = "";//output parameter definition
        switch (number)//evaluate the different cases that results in a letter
        {
            case 2:
                letter = "A";
                break;
            case 22:
                letter = "B";
                break;
            case 222:
                letter = "C";
                break;
            case 3:
                letter = "D";
                break;
            case 33:
                letter = "E";
                break;
            case 333:
                letter = "F";
                break;
            case 4:
                letter = "G";
                break;
            case 44:
                letter = "H";
                break;
            case 444:
                letter = "I";
                break;
            case 5:
                letter = "J";
                break;
            case 55:
                letter = "K";
                break;
            case 555:
                letter = "L";
                break;
            case 6:
                letter = "M";
                break;
            case 66:
                letter = "N";
                break;
            case 666:
                letter = "O";
                break;
            case 7:
                letter = "P";
                break;
            case 77:
                letter = "Q";
                break;
            case 777:
                letter = "R";
                break;
            case 7777:
                letter = "S";
                break;
            case 8:
                letter = "T";
                break;
            case 88:
                letter = "U";
                break;
            case 888:
                letter = "V";
                break;
            case 9:
                letter = "W";
                break;
            case 99:
                letter = "X";
                break;
            case 999:
                letter = "Y";
                break;
            case 9999:
                letter = "Z";
                break;
        }
        return letter;
    }
}