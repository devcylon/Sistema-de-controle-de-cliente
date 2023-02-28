namespace Atividade
{
    class Cliente{
        public String nome {get; set;}
        public String endereco {get; set;}
        public String telefone {get; set;}
        public float valor {get; protected set;}
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}

        public virtual void Pagar_Imposto(float v){
            this.valor = v;
            this.valor_imposto = this.valor * 10/100;
            this.total = this.valor + this.valor_imposto;
        }

    }  
} 