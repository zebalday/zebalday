public class Vendedor extends Empleado{
    
    // ATRIBUTOS
    private int ventas;
    private double comision;
    
    // SETTERS
    public void setVentas(int V)    {this.ventas = V;}
    public void setComision(int C)  {this.comision = C;}
    
    // GETTERS
    public int getVentas()      {return this.ventas;}
    public double getComision()    {return this.comision;}
    
    // CONSTRUCTORES 
    public Vendedor(){}
    public Vendedor(String R, String N, String P, String M, String D, String T, String C, int S, int V, double Com){
        super (R, N, P, M, D, T, C, 400000);
        this.ventas = V;
        this.comision = Com;}
    
    // ESTADO - TOSTRING 
    public String toString(){return super.toString()+
                                    "\nVentas: "+this.ventas+
                                    "\nComision: "+this.comision;}
    
    // VENTA
    public void venta(int valor){
        this.ventas = this.ventas + valor;
        if (this.ventas > 1000000 && this.ventas < 2000000){
            this.comision = this.comision + (valor*0.05);}
        else if (this.ventas > 2000000 && this.ventas < 3000000 ){
            this.comision = this.comision + (valor * 0.1);}
        else if(this.ventas > 3000000){
            this.comision = this.comision + (valor * 0.15);}
        else{}}
        
    // CALCULAR SUELDO 
    public double calcularSueldo(){
        double sueldoBruto;
        sueldoBruto = super.getSueldo() + this.comision;
        return sueldoBruto;}
    
    
    
                                    
                                        
                                    
                                    
                                    
                                    
}


