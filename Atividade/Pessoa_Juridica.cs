namespace Atividade
{
    class Pessoa_Juridica : Cliente{
        public String cnpj;
        public String ie;

        public override void Pagar_Imposto(float v){
            this.valor = v;
            this.valor_imposto = this.valor * 20/100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}