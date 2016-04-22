uses crt;
var
	i,sayi:Byte;
	kelime:string;
begin
	Write('Kelime gir: ');
	Readln(kelime);

	sayi := 10;

	for i:=0 to sayi do
		writeln(kelime,' (',i,')');
	readkey;
end.
