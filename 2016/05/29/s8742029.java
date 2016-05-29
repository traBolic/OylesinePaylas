import java.util.ArrayList;
import java.util.LinkedHashSet;
import java.util.Collections;

class s8742029 {
	public static void main(String args[]) {
		System.out.print("\nEnter N (N<30) integers: ");
		String inputs[] = System.console().readLine().split(" ");

		int N[] = new int[inputs.length];

		for (int i = 0; i < inputs.length; i++)
			N[i] = Integer.parseInt(inputs[i]);

		dispRepTime(N);
	}

	public static void dispRepTime(int[] list) {
		String results = "";

		ArrayList<Integer> list2 = new ArrayList<Integer>();
		for (int value : list) list2.add(value);

		ArrayList<Integer> uniquelist = new ArrayList<Integer>(new LinkedHashSet<Integer>(list2));
		for (Integer hs : uniquelist)
			results += hs + " occurs " + Collections.frequency(list2, hs) + " times ";

		System.out.println("\n" + results);
	}
}
//http://eodev.com/gorev/8742029
