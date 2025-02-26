using pdptask1;
using PDPtask1;

class Program
{
    static void Main()
    {
        Board board = new Board();
        board.DrawBoard();

        Player player = new Player();
        player.SwitchPlayer();
    }
}