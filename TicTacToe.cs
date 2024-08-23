namespace BlazorSample;

public class Square
{
    public char Symbol;
    public bool isFilled {get; set;}
    
    public Square(char symbol = ' ') {
        Symbol = symbol;
    }
}

public class TicTacToe
{
    public string? Title {get; set;}
    public bool GameDone {get; set;}
    
    public List<Square> squares;
    
    public TicTacToe() {
        for(int i = 0; i < 9; i++){
            squares.Add(new Square());
        }
    }
    
    public char GetSymbol(int index){
        return squares[index].Symbol;
    }
}