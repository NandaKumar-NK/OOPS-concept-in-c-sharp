using System;

namespace MyApp
{
    public class Insurance
    {
        private string insuranceNo;
        private string insuranceName;
        private double amountCovered;

        public string InsuranceNo
        {
            get { return insuranceNo; }
            set { insuranceNo = value; }
        }

        public string InsuranceName
        {
            get { return insuranceName; }
            set { insuranceName = value; }
        }

        public double AmountCovered
        {
            get { return amountCovered; }
            set { amountCovered = value; }
        }
    }

    public class MotorInsurance : Insurance
    {
        private double idv;
        private float depPercent;

        public double Idv
        {
            get { return idv; }
            set { idv = value; }
        }

        public float DepPercent
        {
            get { return depPercent; }
            set { depPercent = value; }
        }

        public double CalculatePremium()
        {
            Idv = AmountCovered - ((AmountCovered * DepPercent) / 100);
            return 0.03 * Idv;
        }
    }

    public class LifeInsurance : Insurance
    {
        private int policyTerm;
        private float benefitPercent;

        public int PolicyTerm
        {
            get { return policyTerm; }
            set { policyTerm = value; }
        }

        public float BenefitPercent
        {
            get { return benefitPercent; }
            set { benefitPercent = value; }
        }

        public double CalculatePremium()
        {
            double premium = (AmountCovered - ((AmountCovered * BenefitPercent) / 100)) / PolicyTerm;
            return premium;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insurance Number: ");
                string insuranceNo = Console.ReadLine();

                Console.WriteLine("Insurance Name: ");
                string insuranceName = Console.ReadLine();

                Console.WriteLine("Amount Covered: ");
                double amountCovered = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Select: \n1. Life Insurance \n2. Motor Insurance");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Policy Term: ");
                    int policyTerm = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Benefit Percent: ");
                    float benefitPercent = Convert.ToSingle(Console.ReadLine());

                    LifeInsurance lifeInsurance = new LifeInsurance();
                    lifeInsurance.InsuranceNo = insuranceNo;
                    lifeInsurance.InsuranceName = insuranceName;
                    lifeInsurance.AmountCovered = amountCovered;
                    lifeInsurance.PolicyTerm = policyTerm;
                    lifeInsurance.BenefitPercent = benefitPercent;

                    double premium = AddPolicy(lifeInsurance, option);
                    Console.WriteLine("Calculated Premium: " + premium);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Depreciation Percent: ");
                    float depPercent = Convert.ToSingle(Console.ReadLine());

                    MotorInsurance motorInsurance = new MotorInsurance();
                    motorInsurance.InsuranceNo = insuranceNo;
                    motorInsurance.InsuranceName = insuranceName;
                    motorInsurance.AmountCovered = amountCovered;
                    motorInsurance.DepPercent = depPercent;

                    double premium = AddPolicy(motorInsurance, option);
                    Console.WriteLine("Calculated Premium: " + premium);
                }
                else
                {
                    throw new ArgumentException("Invalid option");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static double AddPolicy(Insurance ins,int opt)
        {
            if (opt == 1)
            {
                if (ins is LifeInsurance)
                {
                    LifeInsurance lifeInsurance = (LifeInsurance)ins;
                    return lifeInsurance.CalculatePremium();
                }
                else
                {
                    throw new ArgumentException("Invalid insurance type");
                }
            }
            else if (opt == 2)
            {
                if (ins is MotorInsurance)
                {
                    MotorInsurance motorInsurance = (MotorInsurance)ins;
                    return motorInsurance.CalculatePremium();
                }
                else
                {
                    throw new ArgumentException("Invalid insurance type");
                }
            }
            else
            {
                throw new ArgumentException("Invalid option");
            }
        }
    }
}