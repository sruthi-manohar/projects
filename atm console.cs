using System;
using System.Collections.Generic;
using System.Linq;
public class cardHolder{
    String fname,lname,cname;
    Int32 pin;
    double bal;
	 public cardHolder(string cname,string fname,string lastname,Int32 pin,double bal){
        this.cname=cname;
        this.fname=fname;
        this.lname=lastname;
        this.bal=bal;
        this.pin=pin;
    }
	 public String getNum(){
        return cname;
    }
    public Int32 getPin(){
        return pin;
    }
    public String getFname(){
        return fname;
    }
    public String getLname(){
        return lname;
    }
    public double getBalance(){
        return bal;
    }

    public void setNum(String newCardNum){
        cname=newCardNum;
    }

    public void setPin(Int32 newPin){
        pin=newPin;
    }
    
    public void setFName(String newFname){
        fname=newFname;
    }

    public void setLName(String newLname){
        lname=newLname;
    }

    public void setBal(double newBal){
        bal=newBal;
    }

     

   

    public static void Main(String[] args){
        void printOptions(){
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void Deposit(cardHolder currentUser){
             Console.WriteLine("How much money would you like to deposit? ");
             double deposit=Double.Parse(Console.ReadLine());
             currentUser.setBal(currentUser.bal+deposit);
              Console.WriteLine("Thank you for your money.your new balance is :" + currentUser.getBalance());

        }

        void Withdraw(cardHolder currentUser){
             Console.WriteLine("how much you gonna to be withdraw: ");
             double withdraw=Double.Parse(Console.ReadLine());
             if(currentUser.getBalance() < withdraw){
                Console.WriteLine("Insufficient Balance");

             }
             else{
                
                currentUser.setBal(currentUser.getBalance()-withdraw);
                Console.WriteLine("your are good to go! thank u");
             }


        }


        void balance(cardHolder currentUser){
            Console.WriteLine("Current Balance: " + currentUser.getBalance());

        }

        List<cardHolder> cardHolders=new List<cardHolder>();
        cardHolders.Add(new cardHolder("1020304050","smith","john",1234,146.78));
        cardHolders.Add(new cardHolder("1020304456","saro","sarah",3435,500.98));
        cardHolders.Add(new cardHolder("1020300987","saaran","sanah",2313,6000.90));
        cardHolders.Add(new cardHolder("1020301572","jen","joy",7809,1000.44));
        
        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum="";
        cardHolder currentUser;

        while(true){
            try{
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a =>a.cname==debitCardNum);
                if(currentUser!=null) {break;}
                else{Console.WriteLine("Card not recognized. Please try again");}
        }
        catch{Console.WriteLine("Card not recognized. Please try again");}

    }

    Console.WriteLine("Please enter your pin: ");
    int userPin=0;
    
        while(true){
            try{
                userPin = int.Parse(Console.ReadLine());
                if(currentUser.getPin()==userPin) {break;}
                else{Console.WriteLine("Incorrect pin.Please try again");}
        }
        catch{Console.WriteLine("Incorrect pin. Please try again");}

    }

    Console.WriteLine("welcome "+ currentUser.getFname()+ ":)");
    int option=0;
    do{
      printOptions();
      try{
        option=int.Parse(Console.ReadLine());
      }
      catch{}
        if(option==1){Deposit(currentUser);}
        else if(option==2){ Withdraw(currentUser);}
        else if(option==3){balance(currentUser);}
        else if(option==4){break;}
        else{option=0;}
      
    }
    while(option!=4);
    Console.WriteLine("Thank you! Have a nice day");
}}
