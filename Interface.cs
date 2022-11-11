//Interface
interface IPatterns
{
  float X { get; set; }
  float A { get; set; }
  float B { get; set; }
  float C { get; set; }
  float D { get; set; }

  float shift_X { get; set; }
  float shift_A { get; set; }
  float shift_B { get; set; }
  float shift_C { get; set; }
  float shift_D { get; set; }

}

class IGartley : IPatterns
{
  public float X { get; set; }
  public float A { get; set; }
  public float B { get; set; }
  public float C { get; set; }
  public float D { get; set; }

  public float shift_X { get; set; }
  public float shift_A { get; set; }
  public float shift_B { get; set; }
  public float shift_C { get; set; }
  public float shift_D { get; set; }

}

class Gartley : IGartley
{
  public int Arms { get; set; }
  public string Times { get; set; }
  public string Shifts { get; set; }
  public string Bars { get; set; }
}