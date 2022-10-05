public class _171ExcelSheetColumnNumber {
    public int TitleToNumber(string columnTitle) {
        
        int x = 0;

        if (columnTitle.Length == 0) return (columnTitle[0] - 'A' +1);
        int y = 1;
        for (int i = columnTitle.Length - 1; i >= 0 ; i--)
        {
            if (y == 1){
                x += (columnTitle[i] - 'A' +1);
            } else {
                x += (columnTitle[i] - 'A' +1) * hhh(y-1);
            }

            y++;
        }

        return x;
    }

    public int hhh(int c){
        int x = 1;
        for (int i = 1; i <= c; i++)
        {
            x *= 26;
        }

        return x;
    }
}