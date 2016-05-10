class Soru8564272 {
	public static void main(String args[]) {
		System.out.print("\nEnter N (N<30) integers: ");
		String inputs[] = System.console().readLine().split(" ");

		int N[] = new int[inputs.length];
		
		for (int i = 0; i < inputs.length; i++)
			N[i] = Integer.parseInt(inputs[i]);

		dispRepTime(N);
	}

	public static void dispRepTime(int[] list) {
		String Result = "";
		int times = 0,
			TempList[] = new int[0];
			
		for (int Number: list) {
			int Status = 0;
			for (int TempNumber: TempList)
				if (Number == TempNumber) 
					Status = 1;
			if (Status == 0) {
				int[] temp = TempList;
				TempList = new int[TempList.length + 1];
				System.arraycopy(temp, 0, TempList, 0, temp.length);
				TempList[TempList.length-1] = Number;
			}
		}

		for (int TempNumber: TempList) {
			for (int Number: list) 
				if (TempNumber == Number)
					times++;
			if (times != 0)
				Result += TempNumber + " occurs " + times + " times ";
			times = 0;
		}
		System.out.println("\n"+Result);
	}
}
//http://eodev.com/gorev/8564272
