
//Encapsulation
public class Pat {
    private float _X,_A,_B,_C,_D;
    private int _shift_X, _shift_A,_shift_B,_shift_C,_shift_D;

    public float X {
        get { return _X; }
        set { if (value !=0) { _X = value;} }
    }public float A {
        get { return _A; }
        set { if (value !=0) { _A = value;} }
    }public float B {
        get { return _B; }
        set {if (value !=0) { _B = value;} }
    }public float C {
        get { return _C; }
        set { if (value !=0) { _C = value;} }
    }public float D {
        get { return _D; }
        set { if (value !=0) { _D = value;} }
    }
    public int shift_X {
        get { return _shift_X; }
        set { if (value !=0) { _shift_X = value;} }
    }public int shift_A {
        get { return _shift_A; }
        set { if (value !=0) { _shift_A = value;} }
    }public int shift_B {
        get { return _shift_B; }
        set {if (value !=0) { _shift_B = value;} }
    }public int shift_C {
        get { return _shift_C; }
        set { if (value !=0) { _shift_C = value;} }
    }public int shift_D {
        get { return _shift_D; }
        set { if (value !=0) { _shift_D = value;} }
    }
}


//Inheritance
class Patterns : Pat
{
    public int Arms { get; set; }
    public string Times { get; set; }
    public string Shifts { get; set; }
    public string Bars { get; set; }

    public static implicit operator Patterns(Gartley v)
    {
        throw new NotImplementedException();
    }
}

class Dragon : Patterns
{
    public string? Fibos { get; set; }
} 

class WhiteSwan : Patterns
{
    public string? Fibos { get; set; }
}

//Polymorphism 
public class Main {
    
    public static void main(String[] args) {
        
        Patterns whiteswan = new WhiteSwan();
        Patterns dragon = new Dragon();
        Patterns pat    = new Patterns();
        
        Patterns gartley = new Gartley();
        
    } 
}