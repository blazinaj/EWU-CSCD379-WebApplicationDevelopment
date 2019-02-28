using System;


[Serializable]
public class Order : IComparable<Order>
{
    // Data to keep track of for each order
    private int mCusNum;

    private string mName;
    private string mStreet;
    private string mCity;
    private string mState;
    private string mZip;

    private int mOrderNum;
    private int mLineNum;
    private string mSKU;
    private string mDescription;
    private int mQty;
    private double mPrice;
    private double mWeight;

    // Constructor with parms for a new date...
    public Order(int cusNum, string name, string street, string city, string state, string zip, int orderNum,
                 int lineNum, string SKU, string description, int qty, double price, double weight)
    {
        this.mCusNum = cusNum;
        this.mName = name;
        this.mStreet = street;
        this.mCity = city;
        this.mState = state;
        this.mZip = zip;
        this.mOrderNum = orderNum;
        this.mLineNum = lineNum;
        this.mSKU = SKU;
        this.mDescription = description;
        this.mQty = qty;
        this.mPrice = price;
        this.mWeight = weight;
    }

    public int CusNum
    {
        get
        {
            return mCusNum;
        }
        set
        {
            this.mCusNum = value;
        }
    }

    public string Name
    {
        get
        {
            return mName;
        }
        set
        {
            this.mName = value;
        }
    }


    public string Street
    {
        get
        {
            return mStreet;
        }
        set
        {
            this.mStreet = value;
        }
    }

    public string City
    {
        get
        {
            return mCity;
        }
        set
        {
            this.mCity = value;
        }
    }


    public string State
    {
        get
        {
            return mState;
        }
        set
        {
            this.mState = value;
        }
    }

    public string Zip
    {
        get
        {
            return mZip;
        }
        set
        {
            this.mZip = value;
        }
    }

    public int OrderNumber
    {
        get
        {
            return mOrderNum;
        }
        set
        {
            this.mOrderNum = value;
        }
    }

    public int LineNumber
    {
        get
        {
            return mLineNum;
        }
        set
        {
            this.mLineNum = value;
        }
    }

    public string SKU
    {
        get
        {
            return mSKU;
        }
        set
        {
            this.mSKU = value;
        }
    }

    public string Description
    {
        get
        {
            return mDescription;
        }
        set
        {
            this.mDescription = value;
        }
    }

    public int Quantity
    {
        get
        {
            return mQty;
        }
        set
        {
            this.mQty = value;
        }
    }

    public double Price
    {
        get
        {
            return mPrice;
        }
        set
        {
            this.mPrice = value;
        }
    }

    public double Weight
    {
        get
        {
            return mWeight;
        }
        set
        {
            this.mWeight = value;
        }
    }

    // Sort the array of orders...
    public int CompareTo(Order that)
    {
        return this.mCusNum - that.mCusNum;
    }


    public override string ToString()
    {
        return this.Name + " " + this.OrderNumber + " " + this.Description;
    }
}
// End Class Order



