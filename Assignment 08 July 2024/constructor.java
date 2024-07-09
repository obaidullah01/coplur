public class constructor{
    public static class company{
        String name;
        int id;
        String field;

        public company(){};
        
        public company(String name, int id, String field){
            this.name = name;
            this.id = id;
            this.field = field;
        }

        public void getter(String objectName){
                System.out.println("The information of " + objectName +" is :");
                System.out.println( "    Name : " + name );
                System.out.println( "    Id : " + id);
                System.out.println( "    Field : " + field );
                System.out.println();
        }
    }
    public static void main(String[] args) {
        company company1 = new company();
        company1.name = "Coplur";
        company1.id = 4595;
        company1.field = "IT Sector";
        
        company company2 = new company("Microsoft",5989,"IT Sector");
        
        company company3 = new company();

        company1.getter("company1");
        company2.getter("company2");
        company3.getter("company3");

       
    
    }
}