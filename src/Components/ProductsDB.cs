using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;


namespace devShop
{

    //*******************************************************
    //
    // ProductDetails Class
    //
    // A simple data class that encapsulates details about
    // a particular product inside the devShop Product
    // database.
    //
    //*******************************************************

    public class ProductDetails
    {

        public String ProductName;
        public String ProductGender;
        public String ProductImage;
        public int ProductPrice;
        public String ProductDescription;
        public String ProductBrand;
        public int CatID;


    }

    public class CatDetails
    {

        public String CatName;
       


    }

    //*******************************************************
    //
    // ProductsDB Class
    //
    // Business/Data Logic Class that encapsulates all data
    // logic necessary to query products within
    // the devShop Products database.
    //
    //*******************************************************

    public class ProductsDB
    {

        SqlConnection dbConnection;
        SqlCommand sqlCommand;
        DataTable allProducts;



        public ProductsDB()
        {
            RegistryKey localKey;
            if (Environment.Is64BitOperatingSystem)
                localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            else
                localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

            string value = localKey.OpenSubKey("SOFTWARE\\Devshop").GetValue("DBConnection").ToString();


            dbConnection = new SqlConnection(value);
            dbConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM Products", dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            allProducts = new DataTable();
            adapter.Fill(allProducts);
            sqlCommand.Dispose();



        }

        public DataTable GetProductCategories()
        {
            sqlCommand = new SqlCommand("SELECT * FROM Categories", dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable categories = new DataTable();
            adapter.Fill(categories);
            sqlCommand.Dispose();
            return categories;
        }

        public DataTable GetProducts(int categoryID)
        {
            sqlCommand = new SqlCommand("SELECT * FROM products WHERE CategoryID = @categoryID", dbConnection);
            sqlCommand.Parameters.AddWithValue("@categoryID", categoryID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable tmpDataTable = new DataTable();
            adapter.Fill(tmpDataTable);
            sqlCommand.Dispose();
            return tmpDataTable;
        }

        public DataTable GetAllProducts()
        {
            sqlCommand = new SqlCommand("SELECT * FROM products WHERE CategoryID IN (1,2,3)", dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable tmpDataTable = new DataTable();
            adapter.Fill(tmpDataTable);
            sqlCommand.Dispose();
            return tmpDataTable;
        }
        public ProductDetails GetProductDetails(int productID)
        {
            sqlCommand = new SqlCommand("SELECT * FROM products WHERE productID = @productID", dbConnection);
            sqlCommand.Parameters.AddWithValue("@productID", productID);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable tmpDataTable = new DataTable();
            adapter.Fill(tmpDataTable);
            sqlCommand.Dispose();

            ProductDetails myProductDetails = new ProductDetails();
            if (tmpDataTable.Rows.Count > 0)
            {

                DataRow result = tmpDataTable.Rows[0];
                myProductDetails.ProductName = result["ProductName"].ToString();
                myProductDetails.ProductBrand = result["ProductBrand"].ToString();
                myProductDetails.ProductImage = result["ProductImage"].ToString();
                myProductDetails.ProductPrice = Int32.Parse(result["ProductPrice"].ToString());
                myProductDetails.ProductDescription = result["ProductDescription"].ToString().Trim();
                myProductDetails.CatID = Int32.Parse(result["CategoryID"].ToString());

            }
            return myProductDetails;
        }

        public CatDetails GetCategoryDetails(int categoryID)
        {
            sqlCommand = new SqlCommand("SELECT * FROM Categories WHERE CategoryID = "+categoryID+"", dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable tmpDataTable = new DataTable();
            adapter.Fill(tmpDataTable);
            sqlCommand.Dispose();
            CatDetails myCatDetails = new CatDetails();
            if (tmpDataTable.Rows.Count > 0)
            {
                DataRow result = tmpDataTable.Rows[0];
                myCatDetails.CatName = result["CategoryName"].ToString();
            }
            return myCatDetails;
        }
        public void insertOrderDetails(int productID, string prodDesc, int catID,string catDesc,int quantity,int totalPrice)
        { 
            sqlCommand = new SqlCommand("INSERT INTO Orders([ProductID], [ProductDesc], [CatID], [Quantity], [TotalPrice],[CatName]) VALUES("+productID+",'"+prodDesc+"','"+catID+"',"+quantity+","+totalPrice+",'"+catDesc+"')", dbConnection);
            int numRec=sqlCommand.ExecuteNonQuery();
            
            sqlCommand.Dispose();
        }

        public DataTable GetMostPopularProductsOfWeek()
        {

            Random r = new Random();
            var rowsTaken = new HashSet<int>();
            DataTable rndTable = allProducts.Clone();
            for (int i = 0; i < 3; i++)
            {
                int rndRowIndex = r.Next(allProducts.Rows.Count);
                while (!rowsTaken.Add(rndRowIndex))
                    rndRowIndex = r.Next(allProducts.Rows.Count);
                DataRow randomRow = allProducts.Rows[rndRowIndex];
                rndTable.ImportRow(randomRow);
            }
            return rndTable;

        }

        public void Dispose()
        {
            if (dbConnection != null)
            {
                dbConnection.Close();
                dbConnection.Dispose();
            }
            if (sqlCommand != null)
            {
                sqlCommand.Dispose();
            }
        }
    }
}