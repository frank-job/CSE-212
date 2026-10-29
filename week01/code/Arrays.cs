public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // double number, => 2.5 with the int length of 5 that will will be (2.5, 5)
    
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // TODO Problem 1 Start
        // PLAN:
        // Step 1: Create a new array of doubles called 'result' with a fixed size equal to 'length'.
        // Step 2: Loop 'i' from 0 up to 'length - 1' to fill each slot of the array.
        // Step 3: For each slot 'i', calculate the multiple by multiplying 'number' by (i + 1).
        //         - Index 0 becomes: (0 + 1) * number = 1 * number
        //         - Index 1 becomes: (1 + 1) * number = 2 * number, etc.
        // Step 4: Assign the calculated multiple value to result[i].
        // Step 5: Return the completed 'result' array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = (i + 1) * number;
        }

        return result;

        // return []; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // TODO Problem 2 Start

        // PLAN:
        // Step 1: Handle list bounds using modulo (%) so 'amount' wraps around if equal to or larger than list size.
        // Step 2: Use GetRange to slice the tail end of the list that needs to move to the front.
        //         - Start index is (data.Count - amount) and we grab 'amount' elements.
        // Step 3: Create a temporary list 'rotated' initialized with these tail elements.
        // Step 4: Use AddRange to append the remaining elements from the front of the original list.
        //         - Start index is 0 and we grab (data.Count - amount) elements.
        // Step 5: Clear the original 'data' list using data.Clear().
        // Step 6: Repopulate 'data' with all elements from 'rotated' using data.AddRange(rotated).

        int count = data.Count;
        amount = amount % count; 

      
        List<int> rotated = new List<int>(data.GetRange(count - amount, amount));

  
        rotated.AddRange(data.GetRange(0, count - amount));

       
        data.Clear();
        data.AddRange(rotated);
    }
    }

