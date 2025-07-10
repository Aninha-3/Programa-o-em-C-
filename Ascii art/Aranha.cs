string caminho = @"C:\Users\Aluno\Documents\GitHub\Programa-o-em-C-\Ascii art\Aranha.cs";

string petalas = @"         ,    
     /\^/`\   
    | \/   |  
    | |    |  
    \ \    /  
     '\\//'   ";
     

string caule = @"
       ||     
       ||     
       ||     
   |\  ||  |\ 
   | | ||  | |
   | | || / / 
    \ \||/ /  
     `\\//` 
 ^^^^^^^^^^^^^^^^
";
string grama = @"

                                                        
                                                  
        ..########mm            ##########        
      ################      ::################    
    ####################  ::####################  
  @@############################################..
  ################################################
  ################################################
mm################################################
MM################################################
..################################################
  ################################################
  ##############################################@@
    ############################################  
      ########################################    
      ..####################################      
        --################################        
          ++############################          
            MM########################..          
              MM####################--            
                @@################++              
                  ##############mm                
                    ##########MM                  
                      ######@@                    
                        ####                      

";

Console.Clear();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(petalas);
Console.ResetColor();
Thread.Sleep(800);

Console.Clear();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(petalas);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(caule);
Console.ResetColor();
Thread.Sleep(750);


Console.Clear();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(petalas);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(caule);;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(grama);
Console.ResetColor();
Thread.Sleep(750);
