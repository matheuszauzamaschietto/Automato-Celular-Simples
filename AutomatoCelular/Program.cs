const int xLength = 500;
const int yLength = 500;
var tabuleiro = new bool[xLength, yLength];

tabuleiro[250, 251] = true;
tabuleiro[250, 250] = true;
tabuleiro[250, 249] = true;

while(true){
    PrintTabuleiro();
    GerarNovaGeracao();
}



void GerarNovaGeracao(){
    var tabuleiroNovo = new bool[xLength, yLength];
    for(int i = 0; i < xLength; i++){
        for(int j = 0; j < yLength; j++){
            tabuleiroNovo[i, j] = funcaoRegra(i, j);
        }
    }
    tabuleiro = tabuleiroNovo;
}

void PrintTabuleiro(){
    for (int i = 0; i < xLength; i++)
    {
        System.Console.Write("-");
    }
    System.Console.Write("\n");
    for(int i = 0; i < xLength; i++){
        for(int j = 0; j < yLength; j++){
            System.Console.Write(tabuleiro[i, j] is true ? "0" : " ");
        }
        System.Console.Write("\n");
    }
    for (int i = 0; i < xLength; i++)
    {
        System.Console.Write("-");
    }
    System.Console.Write("\n");
    //Thread.Sleep(1000);
}

bool funcaoRegra(int x, int y){
    int cont = 0;
    
    for (int i = x-1; i <= x+1; i++)
    {
        for (int j = y-1; j <= y+1; j++)
        {
            if(!(x == i && y == j)){
                try{
                    if(tabuleiro[i, j] is true){
                        cont++;
                    }
                }
                catch(Exception){}
            }
        }
    }

    if(cont <= 1){
        return false;
    }
    else if(cont > 3){
        return false;
    }
    else{
        return true;
    }    
}
