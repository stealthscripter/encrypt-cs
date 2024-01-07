class encrypt{
    


    private List<char> list;
    private List<char> shuffleList;

    private char character;
    private string line;
    private char[] letters;
    private char[] secretLetters;

    // public encrypt(){

    // }

    private void askQuestion(){
        while(true){
            Console.WriteLine("What do you want");
            Console.WriteLine("(N)ewkey , (G)etKey , (E)ncrypt , (D)ecrypt , (Q)uite ");
            char response =  char.Parse(Console.ReadLine());

            switch(response){
                case 'N':
                    // Newkey();
                    break;
                case 'G':
                    // GetKey();
                    break;
                case 'E':
                    // Encrypt();
                    break;
                case 'D':
                    // Decrypt();
                    break;
                case 'Q':
                    // Quite();
                    break;
                default :
                    Console.WriteLine("Invalid Answer :(");
                    break;
            }
        }
    }

    private void NewKey(){
        character = ' ';
        list.Clear();
        shuffleList.Clear();

        for(int i = 32;i < 127;i++){
            list.Add(character);
            character++;
        }
        

    }
}