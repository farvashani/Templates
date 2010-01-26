﻿using System;
using System.Diagnostics;
using NUnit.Framework;

namespace PetShop.Tests.StoredProcedures
{
    [TestFixture]
    public class CategoryTests
    {
        #region Setup

        private string TestCategoryID { get; set; }
        private string TestCategoryID2 { get; set; }

        [NUnit.Framework.TestFixtureSetUp]
        public void Init()
        {
            System.Console.WriteLine(new String('-', 75));
            System.Console.WriteLine("-- Testing the Category Entity --");
            System.Console.WriteLine(new String('-', 75));
        }

        [SetUp]
        public void Setup()
        {
            TestCategoryID = TestUtility.Instance.RandomString(10, false);
            TestCategoryID2 = TestUtility.Instance.RandomString(10, false);

            TearDown();
            CreateCategory(TestCategoryID);
        }

        [TearDown]
        public void TearDown()
        {
            Category.DeleteCategory(TestCategoryID);
            Category.DeleteCategory(TestCategoryID2);
        }

        [NUnit.Framework.TestFixtureTearDown]
        public void Complete()
        {
            System.Console.WriteLine("All Tests Completed");
            System.Console.WriteLine();
        }

        [Test]
        private void CreateCategory(string categoryID)
        {
            Category category = Category.NewCategory();
            category.CategoryId = categoryID;
            category.Name = TestUtility.Instance.RandomString(80, false);
            category.Descn = TestUtility.Instance.RandomString(255, false);

            category = category.Save();

            Assert.IsTrue(category.CategoryId == categoryID);
        }

        #endregion

		/// <summary>
		/// Inserts a Category entity into the database.
		/// </summary>
		[Test]
		public void Step_01_Insert_Duplicate()
		{
            Console.WriteLine("1. Testing Duplicate Records.");
            Stopwatch watch = Stopwatch.StartNew();

            //Insert should fail as there should be a duplicate key.
            Category category = Category.NewCategory();
            category.CategoryId = TestCategoryID;
            category.Name = TestUtility.Instance.RandomString(80, false);
            category.Descn = TestUtility.Instance.RandomString(255, false);

		    try
		    {
                category = category.Save(true);
                
                // Fail as a duplicate record was entered.
                Assert.Fail("Fail as a duplicate record was entered and an exception was not thrown.");
		    }
		    catch (Exception)
		    {
                Assert.IsTrue(true);
            }
            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
		}

        /// <summary>
        /// Inserts a Category entity into the database.
        /// </summary>
        [Test]
        public void Step_02_Insert()
        {
            Console.WriteLine("2. Inserting new category.");
            Stopwatch watch = Stopwatch.StartNew();

            //Insert should fail as there should be a duplicate key.
            Category category = Category.NewCategory();
            category.CategoryId = TestCategoryID2;
            category.Name = TestUtility.Instance.RandomString(80, false);
            category.Descn = TestUtility.Instance.RandomString(255, false);

            category = category.Save(true);

            Assert.IsTrue(true);
            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
		/// Selects a sample of Category objects of the database.
		/// </summary>
		[Test]
		public void Step_03_SelectAll()
		{
            Console.WriteLine("3. Selecting all categories by calling GetByCategoryId(\"{0}\").", TestCategoryID);
            Stopwatch watch = Stopwatch.StartNew();

            CategoryList list = CategoryList.GetByCategoryId(TestCategoryID);
            Assert.IsTrue(list.Count == 1);

            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
		}

        /// <summary>
        /// Updates a Category entity into the database.
        /// </summary>
        [Test]
        public void Step_04_Update()
        {
            Console.WriteLine("4. Updating the category.");
            Stopwatch watch = Stopwatch.StartNew();

            Category category = Category.GetByCategoryId(TestCategoryID);
            var name = category.Name;
            var desc = category.Descn;

            category.Name = TestUtility.Instance.RandomString(80, false);
            category.Descn = TestUtility.Instance.RandomString(255, false);

            category = category.Save();

            Assert.IsFalse(string.Equals(category.Name, name, StringComparison.InvariantCultureIgnoreCase));
            Assert.IsFalse(string.Equals(category.Descn, desc, StringComparison.InvariantCultureIgnoreCase));

            category.Name = name;
            category.Descn = desc;

            category = category.Save();

            Assert.IsTrue(string.Equals(category.Name, name, StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(string.Equals(category.Descn, desc, StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Delete the  Category entity into the database.
        /// </summary>
        [Test]
        public void Step_05_Delete()
        {
            Console.WriteLine("5. Deleting the category.");
            Stopwatch watch = Stopwatch.StartNew();

            Category category = Category.GetByCategoryId(TestCategoryID);
            category.Delete();

            category = category.Save();

            Assert.IsTrue(category.IsNew);
            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Updates a non Identity PK column.
        /// </summary>
        [Test]
        public void Step_06_UpdatePrimaryKey()
        {
            Console.WriteLine("6. Updating the non Identity Primary Key.");
            Stopwatch watch = Stopwatch.StartNew();

            Console.WriteLine("\tGetting category \"{0}\"", TestCategoryID);
            Category category = Category.GetByCategoryId(TestCategoryID);
            category.CategoryId = TestCategoryID2;
            category = category.Save();
            Console.WriteLine("\tSet categoryID to \"{0}\"", TestCategoryID2);
            Assert.IsTrue(category.CategoryId == TestCategoryID2);

            try
            {
                Category invalidCategory = Category.GetByCategoryId(TestCategoryID);

                Assert.Fail("Record exists when it should have been updated.");
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
            
            Category validCategory = Category.GetByCategoryId(TestCategoryID2);
            Assert.IsTrue(validCategory.CategoryId == TestCategoryID2);
            Console.WriteLine("\tPrimaryKey has been updated.");

            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Tests the rules.
        /// </summary>
        [Test]
        public void Step_07_Rules()
        {
            Console.WriteLine("7. Testing the state of the rules for the entity.");
            Stopwatch watch = Stopwatch.StartNew();

            Category category = Category.NewCategory();
            Assert.IsFalse(category.IsValid);

            category.CategoryId = TestCategoryID;
            Assert.IsTrue(category.IsValid);

            category.Name = TestUtility.Instance.RandomString(80, false);
            Assert.IsTrue(category.IsValid);

            category.Descn = TestUtility.Instance.RandomString(255, false);
            Assert.IsTrue(category.IsValid);

            // Check Category.
            category.CategoryId = null;
            Assert.IsFalse(category.IsValid);

            category.CategoryId = TestUtility.Instance.RandomString(11, false);
            Assert.IsFalse(category.IsValid);

            category.CategoryId = TestCategoryID;
            Assert.IsTrue(category.IsValid);

            // Check Name.
            category.Name = null;
            Assert.IsTrue(category.IsValid);

            category.Name = TestUtility.Instance.RandomString(81, false);
            Assert.IsFalse(category.IsValid);

            category.Name = TestUtility.Instance.RandomString(80, false);
            Assert.IsTrue(category.IsValid);

            // Check Descn.
            category.Descn = null;
            Assert.IsTrue(category.IsValid);

            category.Descn = TestUtility.Instance.RandomString(256, false);
            Assert.IsFalse(category.IsValid);

            category.Descn = TestUtility.Instance.RandomString(80, false);
            Assert.IsTrue(category.IsValid);

            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Inserts a Category entity into the database.
        /// </summary>
        [Test]
        public void Step_08_Entity_State()
        {
            Console.WriteLine("8. Checking the state of the entity.");
            Stopwatch watch = Stopwatch.StartNew();

            //Insert should fail as there should be a duplicate key.
            Category category = Category.NewCategory();
            Assert.IsTrue(category.IsDirty);

            category.CategoryId = TestCategoryID2;
            category.Name = TestUtility.Instance.RandomString(80, false);
            category.Descn = TestUtility.Instance.RandomString(255, false);
            
            Assert.IsTrue(category.IsNew);
            Assert.IsTrue(category.IsDirty);
            Assert.IsFalse(category.IsDeleted);

            category = category.Save();

            Assert.IsFalse(category.IsNew);
            Assert.IsFalse(category.IsDirty);
            Assert.IsFalse(category.IsDeleted);

            category.Name = TestUtility.Instance.RandomString(80, false);
            Assert.IsTrue(category.IsDirty);
            category = category.Save(true);

            Assert.IsFalse(category.IsNew);
            Assert.IsTrue(category.IsDirty); // Save docs say this should be the case..
            Assert.IsFalse(category.IsDeleted);

            category.Delete();
            Assert.IsTrue(category.IsDeleted);
            category = category.Save();
            Assert.IsFalse(category.IsDeleted);
            Assert.IsTrue(category.IsNew);

            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Testing Child collections on a new entity.
        /// </summary>
        [Test]
        public void Step_09_New_Entity_Collection()
        {
            Console.WriteLine("9. Testing child collections on a new category.");
            Stopwatch watch = Stopwatch.StartNew();

            Category category = Category.NewCategory();

            Assert.Fail("Need to implement.");
            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Testing Child collections on a new entity.
        /// </summary>
        [Test]
        public void Step_10_Existing_Entity_With_No_Collection()
        {
            Console.WriteLine("10. Testing child collections on a category with no child collection items.");
            Stopwatch watch = Stopwatch.StartNew();

            Category category = Category.NewCategory();

            Assert.Fail("Need to implement.");
            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Selects a sample of Category objects of the database using an invalid category ID.
        /// </summary>
        [Test]
        public void Step_12_SelectAll_Invalid_Value()
        {
            Console.WriteLine("12. Selecting all categories by calling GetByCategoryId with an invalid value");
            Stopwatch watch = Stopwatch.StartNew();

            try
            {
                CategoryList.GetByCategoryId(TestUtility.Instance.RandomString(10, false));

                Assert.Fail("This call to GetByCategoryID should throw an exception");
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Selects a sample of Category objects of the database using an invalid category ID.
        /// </summary>
        [Test]
        public void Step_13_SelectAll_With_Oversized_CategoryID()
        {
            Console.WriteLine("13. Selecting all categories by calling GetByCategoryId with an invalid value");
            Stopwatch watch = Stopwatch.StartNew();

            try
            {
                CategoryList.GetByCategoryId(TestCategoryID + "a");

                Assert.Fail("This call to GetByCategoryID should throw an exception");
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }

            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Testing Insert Child collections on a new entity.
        /// </summary>
        [Test]
        public void Step_14_Insert_Child_Collection_On_New_Category()
        {
            Console.WriteLine("14. Testing insert on child collections in a new category.");
            Stopwatch watch = Stopwatch.StartNew();

            Category category = Category.NewCategory();

            Assert.Fail("Need to implement.");
            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Testing Insert Child collections on an existing entity.
        /// </summary>
        [Test]
        public void Step_15_Insert_Child_Collection()
        {
            Console.WriteLine("15. Testing insert on child collections in a category.");
            Stopwatch watch = Stopwatch.StartNew();

            Category category = Category.NewCategory();

            Assert.Fail("Need to implement.");
            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Testing update on a new child collections on a new entity.
        /// </summary>
        [Test]
        public void Step_16_Update_Child_Collection_On_New_Category()
        {
            Console.WriteLine("16. Testing update on new child collections in a new category.");
            Stopwatch watch = Stopwatch.StartNew();

            Category category = Category.NewCategory();

            Assert.Fail("Need to implement.");
            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Testing update Child collections on an existing entity.
        /// </summary>
        [Test]
        public void Step_17_Update_Child_Collection()
        {
            Console.WriteLine("17. Testing update on child collections in a category.");
            Stopwatch watch = Stopwatch.StartNew();

            Category category = Category.NewCategory();

            Assert.Fail("Need to implement.");
            Console.WriteLine("Time: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}