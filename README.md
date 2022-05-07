# Roman numerals generator
Task is to create a converter from integers to roman numerals.  
Integer range is 1 to 3999.  
Example:
- 1    = "I"
- 5    = "V"
- 10   = "X"
- 20   = "XX"
- 3999 = "MMMCMXCIX"

## Algorithm
To start coding the converter, we need to undestand how roman numerals are structured.  
First of all, in roman numerals, we have defined symbols.  
You can see them in the table below:  
![defined symbols](https://i.ibb.co/sRLB0X2/image-2022-05-07-113403343.png)  
And these symbols usually corresponds to the specific decimal place in number, you can see that in the table below:  
![roman numerals table](https://i.ibb.co/vqjJh2g/image-2022-05-07-112643649.png)  
From that information, we can see 2 things
### 1. Start symbols
In the table below, I selected all start symbols in each decimal place:  
![start symbols in table](https://i.ibb.co/B47vcdd/image-2022-05-07-114955369.png)
- Thousands = "M"
- Hundreds  = "C"
- Tens      = "X"
- Units     = "I"
### 2. Middle symbols
In the table below, I selected all middle symbols in each decimal place:  
![middle symbols in table](https://i.ibb.co/Vtxck84/image-2022-05-07-115655736.png)
- Hundreds = "D"
- Tens     = "L"
- Units    = "V"

### Result construction
Now, when we have our start symbol and middle symbol for the current decimal place,  
we can start to construct your final roman numeral.  
As we can see, in every decimal place:
- From number 1 - 3, we just spam start symbol of that decimal place
- For number 4, we get start symbol and then, add middle symbol
- For number 5, we add middle symbol
- For number 6 - 8, we get middle symbol and then, spam start symbol
- For number 9, we get start symbol of current decimal and then, add start symbol of the next decimal place  
  
Lets get an example:  
We have an number '246'  
Going through each individual number:  
1. We have number 2 and decimal place is 3 (Hundreds). So our symbol will be, just start symbols = "CC".
2. We have number 4 and decimal place is 2 (Tens). So our symbols will be, start symbol and middle symbol = "XL".
3. We have number 6 and decimal place is 1 (Units). So our symbols will be, middle symbol and start symbol = "VI".
Putting these 3 results together will give us an answer = "CCXLVI". 
  
## Testing
To test our roman numeral generator, I created some unit tests.  
I chose 5 groups of unit tests:  
1. Testing simple predefined symbols
2. Testing maximal range
3. Testing invalid range
4. Testing advanced symbol combinations
5. Testing number with zeros  
  
During the tests writing, I got a bug:  
Problem with the Spam function, when number is in range from 6-8.  
E.g if number is 7, the result I get, was VIIIIIII  
I've made a code a little bit more complicated, than it should be, and made a mistake.  
I simplified the code and now, all tests is passed.
