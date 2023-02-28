using System;
namespace Atividade
{
    class Program{
        private static string var_tipo;

        static void Main(string[] args){
            
            Console.WriteLine("Informe seu Nome:");
            String var_nome = Console.ReadLine();
            Console.WriteLine("Informe seu endereço:");
            String var_endereço = Console.ReadLine();
            Console.WriteLine("Informe seu telefone com DD:");
            String var_telefone = Console.ReadLine();
            int x =0;
            var_tipo ="";
            do{
                Console.WriteLine("Imforme F p/ pessoa física ou J p/ pessoa jurídica");
                var_tipo = Console.ReadLine();
                if(var_tipo == "F" || var_tipo == "J"){
                    x=1;
                }    
            }
            while(x!=1);
            if(var_tipo == "F"){
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome=var_nome;
                pf.endereco = var_endereço;
                pf.telefone = var_telefone;
                do{
                    Console.WriteLine("Informe o 11 digitos do seu CPF:");
                pf.cpf = Console.ReadLine();}
                while(pf.cpf.Length!=11);            
                Console.WriteLine("Informe seu RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe valor da compra:");
                float var_valor =float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(var_valor);
                Console.WriteLine("--------------------- Pessoa Física ---------------------");
                Console.WriteLine("Nome ..............: "+ pf.nome);
                Console.WriteLine("Endereço ..........: "+ pf.endereco);
                Console.WriteLine("Telefone ..........: "+ Convert.ToUInt64(pf.telefone).ToString(@"(00)00000\-0000"));
                Console.WriteLine("CPF ...............: "+ Convert.ToUInt64(pf.cpf).ToString(@"000\.000\.000\-00"));
                Console.WriteLine("RG ................: "+ pf.rg);
                Console.WriteLine("Valor da compra ...: " + pf.valor.ToString("C"));
                Console.WriteLine("Valor do imposto ..: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total .............: " + pf.total.ToString("C"));
            }
            else{
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereço;
                pj.telefone = var_telefone;
                do{
                Console.WriteLine("Informe os 14 números doseu CNPJ:");
                pj.cnpj = Console.ReadLine();
                }
                while(pj.cnpj.Length!=14);
                Console.WriteLine("Informe seu IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe valor da compra:");
                float var_valor = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(var_valor);
                Console.WriteLine("--------------------- Pessoa Jurídica ---------------------");
                Console.WriteLine("Nome ..............: "+ pj.nome);
                Console.WriteLine("Endereço ..........: "+ pj.endereco);
                Console.WriteLine("Endereço ..........: "+ Convert.ToUInt64(pj.telefone).ToString(@"(00)00000\-0000"));
                Console.WriteLine("CNPJ ..............: "+ Convert.ToUInt64(pj.cnpj).ToString(@"00\.000\.000\/0000\-00"));
                Console.WriteLine("IE ................: "+ pj.ie);
                Console.WriteLine("Valor da compra ...: " + pj.valor.ToString("C"));
                Console.WriteLine("Valor do imposto ..: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total .............: " + pj.total.ToString("C"));
            }  
                Console.WriteLine("----------------------------------------------------------");
        }
    }
}
