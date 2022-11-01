class Animal
{
    private int height;
    private int Tthresh = 100;
    private int Sthresh = 50;
    public Animal(int height) {
        this.height = height;
    }
    private int grow() {
        for (int i = 0; i <= 10; i++){
            this.height++;
        }
        return this.height;
    }
    public string getHeight() {
        if (this.height > this.Tthresh) {
            return "Tall Mofo";
        }
        else if (this.height < this.Sthresh) {
            return "Short Mofo";
        }
        else {
            return "Medium Mofo";
        }
    }
}