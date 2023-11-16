package dado;
import java.util.Random;
public class Dado {
	public static final int FACE = 6;
	private int face;
	public Dado(){
		
	}
	public void rolar() {
		Random rand = new Random();
		face = rand.nextInt(FACE)+ 1;
	}
	public int obterFace() {
		return face;
	}
	
	public static void main(String[] args) {
		Dado d1 = new Dado();
		d1.rolar();
		System.out.println("Face "+ d1.obterFace());
	}

}


/*class Dado{
  private: //default
    int face;
  public:
    Dado(){srand(time(0));rolar();};
    const static int FACES=6;
    int obterFace();
    void rolar();
};

int Dado::obterFace(){return face;}
void Dado::rolar(){face=rand()%FACES + 1;}
 */