int contador = 0;
string linea;

System.IO.StreamReader archivo =   
    new System.IO.StreamReader(@"C:\Users\Michelita\Desktop\automatizar-pruebas-unitarias-2019-MaricruzCF\CasosPrueba.txt");  
while((linea = archivo.ReadLine()) != null)  
{  
    System.Console.WriteLine(linea);  
    contador++;  
}  
  
archivo.Close();  
System.Console.WriteLine("There were {0} lines.", contador);  

System.Console.ReadLine();  