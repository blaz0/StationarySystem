/*
function Test1()
{
    //Clicks at point (808, 23) of the 'MSTaskListWClass' object.
    Aliases.explorer.wndShell_TrayWnd.ReBarWindow32.MSTaskSwWClass.MSTaskListWClass.Click(808, 23);
    //Clicks at point (52, 12) of the 'StaffIDTF' object.
    Aliases.StationarySystem.LoginForm.StaffIDTF.Click(52, 12);
    //Enters the text '128755' in the 'StaffIDTF' text editor.
    Aliases.StationarySystem.LoginForm.StaffIDTF.SetText("128755");
    //Enters '[Tab]' in the 'StaffIDTF' object.
    Aliases.StationarySystem.LoginForm.StaffIDTF.Keys("[Tab]");
    //Enters the text 'sdfghj' in the 'PasswordTF' text editor.
    Aliases.StationarySystem.LoginForm.PasswordTF.SetText("sdfghj");
    //Clicks the 'LoginBtn' button.
    Aliases.StationarySystem.LoginForm.LoginBtn.ClickButton();
    //Checks whether the 'Enabled' property of the Aliases.StationarySystem.dlg object equals True.
    aqObject.CheckProperty(Aliases.StationarySystem.dlg, "Enabled", cmpEqual, true);
    //Clicks the 'btnOK' button.
    Aliases.StationarySystem.dlg.btnOK.ClickButton();
    //Enters the text '12875579' in the 'StaffIDTF' text editor.
    Aliases.StationarySystem.LoginForm.StaffIDTF.SetText("12875579");
    //Enters '[Tab]' in the 'StaffIDTF' object.
    Aliases.StationarySystem.LoginForm.StaffIDTF.Keys("[Tab]");
    //Enters the text 'maxine' in the 'PasswordTF' text editor.
    Aliases.StationarySystem.LoginForm.PasswordTF.SetText("maxine");
    //Clicks the 'LoginBtn' button.
    Aliases.StationarySystem.LoginForm.LoginBtn.ClickButton();
    //Clicks at point (64, 45) of the 'ProductPic' object.
    Aliases.StationarySystem.Home.ProductPic.Click(64, 45);
    //Checks whether the 'Enabled' property of the Aliases.StationarySystem.ProductsForm.productDataGrid object equals True.
    aqObject.CheckProperty(Aliases.StationarySystem.ProductsForm.productDataGrid, "Enabled", cmpEqual, true);
    //Clicks the 'CreateRequestBtn' button.
    Aliases.StationarySystem.ProductsForm.CreateRequestBtn.ClickButton();
    //Checks whether the 'Enabled' property of the Aliases.StationarySystem.CreateStationeryRequestForm.groupOrder object equals True.
    aqObject.CheckProperty(Aliases.StationarySystem.CreateStationeryRequestForm.groupOrder, "Enabled", cmpEqual, true);
    //Clicks the 'SubmitBtn' button.
    Aliases.StationarySystem.CreateStationeryRequestForm.SubmitBtn.ClickButton();
    //Clicks the 'btnOK' button.
    Aliases.StationarySystem.dlg.btnOK.ClickButton();
    //Clicks the 'BtnSystemSettings' button.
    Aliases.StationarySystem.ProductsForm.panel1.BtnSystemSettings.ClickButton();
    //Checks whether the 'Enabled' property of the Aliases.StationarySystem.RequestsForm.requestDataGrid object equals True.
    aqObject.CheckProperty(Aliases.StationarySystem.RequestsForm.requestDataGrid, "Enabled", cmpEqual, true);
    //Checks whether the 'wColumnCount' property of the Aliases.StationarySystem.RequestsForm.requestDataGrid object equals 9.
    aqObject.CheckProperty(Aliases.StationarySystem.RequestsForm.requestDataGrid, "wColumnCount", cmpEqual, 9);
    //Clicks the 'requestDataGrid' grid cell at row 0, column 'Quantity'.
    Aliases.StationarySystem.RequestsForm.requestDataGrid.ClickCell(0, "Quantity");
    //Clicks the 'CancelBtn' button.
    Aliases.StationarySystem.RequestsForm.CancelBtn.ClickButton();
    //Clicks the 'btnOK' button.
    Aliases.StationarySystem.dlg.btnOK.ClickButton();
    //Clicks the 'EditBtn' button.
    Aliases.StationarySystem.RequestsForm.EditBtn.ClickButton();
    //Clicks the 'btnOK' button.
    Aliases.StationarySystem.dlg.btnOK.ClickButton();
    //Clicks the 'requestDataGrid' grid cell at row 7, column 'Quantity'.
    Aliases.StationarySystem.RequestsForm.requestDataGrid.ClickCell(7, "Quantity");
    //Clicks the 'requestDataGrid' grid cell at row 2, column 'Quantity'.
    Aliases.StationarySystem.RequestsForm.requestDataGrid.ClickCell(2, "Quantity");
    //Clicks the 'CancelBtn' button.
    Aliases.StationarySystem.RequestsForm.CancelBtn.ClickButton();
    //Clicks the 'btnYes' button.
    Aliases.StationarySystem.dlg.btnYes.ClickButton();
    //Clicks the 'requestDataGrid' grid cell at row 2, column 'Quantity'.
    Aliases.StationarySystem.RequestsForm.requestDataGrid.ClickCell(2, "Quantity");
    //Clicks the 'EditBtn' button.
    Aliases.StationarySystem.RequestsForm.EditBtn.ClickButton();
    //Sets the value of the UpDown control 'Qty' to 2.
    Aliases.StationarySystem.RequestsForm.Qty.wValue = 2;
    //Clicks the 'SaveBtn' button.
    Aliases.StationarySystem.RequestsForm.SaveBtn.ClickButton();
    //Clicks the 'btnYes' button.
    Aliases.StationarySystem.dlg.btnYes.ClickButton();
    //Clicks at point (26, 31) of the 'LogOutBtn' object.
    Aliases.StationarySystem.RequestsForm.LogOutBtn.Click(26, 31);
    //Enters the text '12875795' in the 'StaffIDTF' text editor.
    Aliases.StationarySystem.LoginForm.StaffIDTF.SetText("12875795");
    //Clicks at point (80, 19) of the 'PasswordTF' object.
    Aliases.StationarySystem.LoginForm.PasswordTF.Click(80, 19);
    //Enters the text 'julia' in the 'PasswordTF' text editor.
    Aliases.StationarySystem.LoginForm.PasswordTF.SetText("julia");
    //Clicks the 'LoginBtn' button.
    Aliases.StationarySystem.LoginForm.LoginBtn.ClickButton();
    //Clicks at point (45, 51) of the 'OkPicture' object.
    Aliases.StationarySystem.Home.OkPicture.Click(45, 51);
    //Clicks the 'requestDataGrid' grid cell at row 0, column 'Product Name'.
    Aliases.StationarySystem.ApproveRequestForm.requestDataGrid.ClickCell(0, "Product Name");
    //Clicks the 'requestDataGrid' grid cell at row 1, column 'Quantity'.
    Aliases.StationarySystem.ApproveRequestForm.requestDataGrid.ClickCell(1, "Quantity");
    //Clicks the 'ApproveBtn' button.
    Aliases.StationarySystem.ApproveRequestForm.ApproveBtn.ClickButton();
    //Clicks the 'btnYes' button.
    Aliases.StationarySystem.dlg.btnYes.ClickButton();
    //Clicks the 'requestDataGrid' grid cell at row 1, column 'Quantity'.
    Aliases.StationarySystem.ApproveRequestForm.requestDataGrid.ClickCell(1, "Quantity");
    //Clicks the 'RejectBtn' button.
    Aliases.StationarySystem.ApproveRequestForm.RejectBtn.ClickButton();
    //Clicks the 'btnYes' button.
    Aliases.StationarySystem.dlg.btnYes.ClickButton();
    //Clicks the 'BtnProducts' button.
    Aliases.StationarySystem.ApproveRequestForm.panel1.BtnProducts.ClickButton();
    //Rotates the mouse wheel to -1 over the 'detailsDataGrid' object.
    Aliases.StationarySystem.ProductsForm.detailsDataGrid.MouseWheel(-1);
    //Checks whether the 'Enabled' property of the Aliases.StationarySystem.ProductsForm.detailsDataGrid object equals True.
    aqObject.CheckProperty(Aliases.StationarySystem.ProductsForm.detailsDataGrid, "Enabled", cmpEqual, true);
    //Checks whether the 'wColumnCount' property of the Aliases.StationarySystem.ProductsForm.detailsDataGrid object equals 6.
    aqObject.CheckProperty(Aliases.StationarySystem.ProductsForm.detailsDataGrid, "wColumnCount", cmpEqual, 6);
    //Clicks at point (17, 32) of the 'PictureBox1' object.
    Aliases.StationarySystem.ProductsForm.PictureBox1.Click(17, 32);
}
*/