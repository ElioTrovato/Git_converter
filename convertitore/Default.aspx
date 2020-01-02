<%@ Page Title="Converter" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="convertitore._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <h1 style="color:whitesmoke; text-align:center">Welcome to the Unit Converter!</h1>

        <br /><br />
    <div class="text-center">
    <asp:Button ID="Button1" runat="server" Style="height: 70px;width: 70px;border-radius: 35px; border-left-width: 4px;
    border-top-width: 4px;
    border-bottom-width: 4px;
    border-right-width: 4px;"
      CssClass="btn-danger" OnClick="Button1_Click" Text="Reset all" />       
     </div>
        <br /><br />
      
        <%-- Using UpdatePanel option to update an area of the webpage so the entire page doesn't refresh, rememeber to include AJAX ScriptManager! --%>
   <div class="containerr" style="padding:40px; background-color:rgba(73,73,73,0.9); border-radius: 15px; "  >
        <%-- Display For Angle Converter --%>
       <div class="row">
           <div class="col-sm-6">
        <asp:UpdatePanel ID="AngleUpdate" runat="server">
            <ContentTemplate>
                <asp:panel id="pnlAngle" runat="server" DefaultButton="AngleButton" >
          <asp:Label ID="LabelAngle" runat="server" Text="Angle " Font-Bold="True" Font-Size="Large" ForeColor="WhiteSmoke"></asp:Label>
         <br />
        <h5 style="color:whitesmoke">From: </h5>
        <asp:TextBox ID="AngleFrom" CssClass="btn btn-default btn-sm" placeholder="Enter a Value" runat="server" BorderStyle="Inset" Font-Bold="True" ></asp:TextBox>
        <asp:DropDownList ID="FromList" CssClass="btn btn-default btn-sm" runat="server" OnSelectedIndexChanged="FromList_SelectedIndexChanged"  Width="115px" AutoPostBack="True">
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="Celsius">Celsius</asp:ListItem>
            <asp:ListItem Value="Kelvin">Kelvin</asp:ListItem>
            <asp:ListItem Value="Fahrenheit">Fahrenheit</asp:ListItem>
        </asp:DropDownList>
        <br />
        <h5 style="color:whitesmoke">To: </h5>
        <asp:TextBox ID="AngleTo" CssClass="btn btn-default btn-sm" runat="server" BorderStyle="Inset" Font-Bold="True" ReadOnly="True"></asp:TextBox>
        <asp:DropDownList ID="ToList"  CssClass="btn btn-default btn-sm" runat="server" Width="115px" AutoPostBack="True" OnSelectedIndexChanged="ToList_SelectedIndexChanged">
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="Celsius">Celsius</asp:ListItem>
            <asp:ListItem Value="Kelvin">Kelvin</asp:ListItem>
            <asp:ListItem Value="Fahrenheit">Fahrenheit</asp:ListItem>
        </asp:DropDownList>
        <br />
                <asp:Label ID="AngleReponse" runat="server" Font-Bold="true" ForeColor="WhiteSmoke"></asp:Label>
                <br />
                <div class="angleButton">
                    <asp:Button ID="AngleButton" runat="server" Text="Calculate" OnClick="angleButton_Click" CssClass="btn-primary"/>                    
                    <asp:Button ID="angleReset" runat="server" Text="Reset"  CssClass="btn-primary" OnClick="angleReset_Click"/> 
                    <asp:Button ID="angleSwap" runat="server" Text="Swap"  CssClass="btn-primary" OnClick="angleSwap_Click"/>         
                    
                    <hr />
                </div>
                    </asp:panel>
                </ContentTemplate>
            <triggers>
                <asp:asyncpostbacktrigger controlid="FromList" eventname="SelectedIndexChanged" /> 
             </triggers>
            </asp:UpdatePanel>    
           </div>

            <div class="col-sm-6">
        <%-- Display For Lenght Converter --%>
       <asp:UpdatePanel ID="LenghtUpdate" runat="server">
            <ContentTemplate>
                <asp:panel id="pnlLenght" runat="server" DefaultButton="btnLenghtCalculate" >
         <asp:Label ID="LabelLenght" runat="server" Text="Lenght" Font-Bold="True" Font-Size="Large" ForeColor="WhiteSmoke"></asp:Label>
         <br />
        <h5 style="color:whitesmoke">From: </h5>
        <asp:TextBox ID="LenghtFrom" CssClass="btn btn-default btn-sm" placeholder="Enter a Value"  runat="server" BorderStyle="Inset" Font-Bold="True" ></asp:TextBox>
        <asp:DropDownList ID="FromListLenght" CssClass="btn btn-default btn-sm" runat="server" autopostback="true"  OnSelectedIndexChanged="FromListLenght_SelectedIndexChanged"  Width="115px">
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="Meters">Meters</asp:ListItem>
            <asp:ListItem Value="Miles">Miles</asp:ListItem>
            <asp:ListItem Value="Yards">Yards</asp:ListItem>
            <asp:ListItem Value="Feet">Feet</asp:ListItem>
        </asp:DropDownList>
        <br />
        <h5 style="color:whitesmoke">To: </h5>
        <asp:TextBox ID="LenghtTo" CssClass="btn btn-default btn-sm" runat="server" BorderStyle="Inset" Font-Bold="True" ReadOnly="True"></asp:TextBox>
        <asp:DropDownList ID="ToListLenght" CssClass="btn btn-default btn-sm" autopostback="true" runat="server" Width="115px">
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="Meters">Meters</asp:ListItem>
            <asp:ListItem Value="Miles">Miles</asp:ListItem>
            <asp:ListItem Value="Yards">Yards</asp:ListItem>
            <asp:ListItem Value="Feet">Feet</asp:ListItem>
        </asp:DropDownList>
        <br />
                <asp:Label ID="LenghtResoponse" runat="server" Font-Bold="true" ForeColor="WhiteSmoke"></asp:Label>
                <br />
                <div class="lenghtButton">
                    <asp:Button ID="btnLenghtCalculate" runat="server" Text="Calculate"  CssClass="btn-primary" OnClick="btnLenghtCalculate_Click"/>    
                    <asp:Button ID="btnLenghtReset" runat="server" Text="Reset"  CssClass="btn-primary" OnClick="btnLenghtReset_Click" />         
                    <asp:Button ID="lenghtSwap" runat="server" CssClass="btn-primary" Text="Swap" OnClick="lenghtSwap_Click" />
                    <hr />
                </div>
                    </asp:panel>
                </ContentTemplate>
            <triggers>
              <asp:asyncpostbacktrigger controlid="FromListLenght" eventname="SelectedIndexChanged" /> 
             </triggers>
            </asp:UpdatePanel>    
             </div> 

       </div>      
    <div class="row">
            <div class="col-sm-6">
       <%-- Display For Mass Converter --%>
       <asp:UpdatePanel ID="MassUpdate" runat="server">
            <ContentTemplate>
       <asp:panel id="pnlMass" runat="server" DefaultButton="ButtonMassCalculate" >
         <asp:Label ID="LabelMass" runat="server" Text="Mass" Font-Bold="True" Font-Size="Large" ForeColor="WhiteSmoke"></asp:Label>
         <br />
        <h5 style="color:whitesmoke">From: </h5>
        <asp:TextBox ID="MassFrom" CssClass="btn btn-default btn-sm" placeholder="Enter a Value" runat="server" BorderStyle="Inset" Font-Bold="True"></asp:TextBox>
        <asp:DropDownList ID="MassFromList" CssClass="btn btn-default btn-sm" runat="server" autopostback="true"   Width="115px" OnSelectedIndexChanged="MassFromList_SelectedIndexChanged">
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="kilogram">kilogram</asp:ListItem>
            <asp:ListItem Value="Pound">Pound</asp:ListItem>
            <asp:ListItem Value="Ounce">Ounce</asp:ListItem>
        </asp:DropDownList>
        <br />
        <h5 style="color:whitesmoke">To: </h5>
        <asp:TextBox ID="MassTo" CssClass="btn btn-default btn-sm" runat="server" BorderStyle="Inset" Font-Bold="True" ReadOnly="True"></asp:TextBox>
        <asp:DropDownList ID="MassToList" CssClass="btn btn-default btn-sm" autopostback="true" runat="server" Width="115px">
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="kilogram">kilogram</asp:ListItem>
            <asp:ListItem Value="Pound">Pound</asp:ListItem>
            <asp:ListItem Value="Ounce">Ounce</asp:ListItem>
        </asp:DropDownList>
        <br />
                <asp:Label ID="MassResponse" runat="server" Font-Bold="true" ForeColor="WhiteSmoke"></asp:Label>
                <br />
                <div class="massButton">
                    <asp:Button ID="ButtonMassCalculate" runat="server" Text="Calculate"  CssClass="btn-primary" OnClick="ButtonMassCalculate_Click"  />    
                    <asp:Button ID="ButtonMassReset" runat="server" Text="Reset"  CssClass="btn-primary" OnClick="ButtonMassReset_Click"  />         
                    <asp:Button ID="massSwap1" runat="server" CssClass="btn-primary" Text="Swap" OnClick="massSwap1_Click" />
                    <hr />
                </div>
           </asp:panel>
                </ContentTemplate>
            <triggers>
              <asp:asyncpostbacktrigger controlid="MassFromList" eventname="SelectedIndexChanged" />                               
             </triggers>
            </asp:UpdatePanel>    
                  </div> 
        <div class="col-sm-6">
        <%-- Display For Time Converter --%>
       <asp:UpdatePanel ID="timeUpdate" runat="server">
            <ContentTemplate>
           <asp:panel id="pnlTime" runat="server" DefaultButton="brnCalculate" >
         <asp:Label ID="LabelTime" runat="server" Text="Time" Font-Bold="True" Font-Size="Large" ForeColor="WhiteSmoke"></asp:Label>
         <br />
        <h5 style="color:whitesmoke">From: </h5>
        <asp:TextBox ID="TimeFrom" CssClass="btn btn-default btn-sm" placeholder="Enter a Value" runat="server" BorderStyle="Inset" Font-Bold="True" ></asp:TextBox>
        <asp:DropDownList ID="DropDownListFrom"  CssClass="btn btn-default btn-sm" runat="server" autopostback="true"   Width="115px" OnSelectedIndexChanged="DropDownListFrom_SelectedIndexChanged"  >
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="Seconds">Seconds</asp:ListItem>
            <asp:ListItem Value="Minutes">Minutes</asp:ListItem>
            <asp:ListItem Value="Hours">Hours</asp:ListItem>
        </asp:DropDownList>
        <br />
        <h5 style="color:whitesmoke">To: </h5>
        <asp:TextBox ID="TimeTo" CssClass="btn btn-default btn-sm" runat="server" BorderStyle="Inset" Font-Bold="True" ReadOnly="True"></asp:TextBox>
        <asp:DropDownList ID="DropDownListTo" CssClass="btn btn-default btn-sm" autopostback="true" runat="server" Width="115px">
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="Seconds">Seconds</asp:ListItem>
            <asp:ListItem Value="Minutes">Minutes</asp:ListItem>
            <asp:ListItem Value="Hours">Hours</asp:ListItem>
        </asp:DropDownList>
        <br />
                <asp:Label ID="TimeResponse" runat="server" Font-Bold="true" ForeColor="WhiteSmoke"></asp:Label>
                <br />
                <div class="timeButton">
                    <asp:Button ID="brnCalculate" runat="server" Text="Calculate"  CssClass="btn-primary" OnClick="brnCalculate_Click"    />    
                    <asp:Button ID="btnReset" runat="server" Text="Reset"  CssClass="btn-primary" OnClick="btnReset_Click"    />         
                    <asp:Button ID="timeSwap" runat="server" CssClass="btn-primary" Text="Swap" OnClick="timeSwap_Click" />
                    <hr />
                </div>
               </asp:panel>
                </ContentTemplate>
            <triggers>
              <asp:asyncpostbacktrigger controlid="DropDownListFrom" eventname="SelectedIndexChanged" />                               
             </triggers>
            </asp:UpdatePanel>    
             </div>  

    </div>   
                  <div class="row"> 
           <div class="col-sm-6">

        <%-- Display For Pressure Converter --%>
       <asp:UpdatePanel ID="PressureUpdate" runat="server">
            <ContentTemplate>
                <asp:panel id="pnlPressure" runat="server" DefaultButton="btnPressureCalculate" >
         <asp:Label ID="LabelPressure" runat="server" Text="Pressure " Font-Bold="True" Font-Size="Large" ForeColor="WhiteSmoke"></asp:Label>
         <br />
        <h5 style="color:whitesmoke">From: </h5>
        <asp:TextBox ID="PressureFrom" CssClass="btn btn-default btn-sm" placeholder="Enter a Value" runat="server" BorderStyle="Inset" Font-Bold="True" ></asp:TextBox>
        <asp:DropDownList ID="FromListPressure" CssClass="btn btn-default btn-sm" runat="server" autopostback="true"   Width="115px" OnSelectedIndexChanged="FromListPressure_SelectedIndexChanged"   >
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="Pascal">Pascal</asp:ListItem>
            <asp:ListItem Value="Bar">Bar</asp:ListItem>
            <asp:ListItem Value="Torr">Torr</asp:ListItem>
            <asp:ListItem Value="Atmosphere">Atmosphere</asp:ListItem>
        </asp:DropDownList>
        <br />
        <h5 style="color:whitesmoke">To: </h5>
        <asp:TextBox ID="PressureTo" CssClass="btn btn-default btn-sm" runat="server" BorderStyle="Inset" Font-Bold="True" ReadOnly="True"></asp:TextBox>
        <asp:DropDownList ID="ToListPressure" CssClass="btn btn-default btn-sm" autopostback="true" runat="server" Width="115px">
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="Pascal">Pascal</asp:ListItem>
            <asp:ListItem Value="Bar">Bar</asp:ListItem>
            <asp:ListItem Value="Torr">Torr</asp:ListItem>
            <asp:ListItem Value="Atmosphere">Atmosphere</asp:ListItem>
        </asp:DropDownList>
        <br />
                <asp:Label ID="PressureResponse" runat="server" Font-Bold="true" ForeColor="WhiteSmoke"></asp:Label>
                <br />
                <div class="pressureButton">
                    <asp:Button ID="btnPressureCalculate" runat="server" Text="Calculate"  CssClass="btn-primary" OnClick="btnPressureCalculate_Click"  />    
                    <asp:Button ID="btnPressureReset" runat="server" Text="Reset"  CssClass="btn-primary" OnClick="btnPressureReset_Click"    />         
                    <asp:Button ID="pressureSwap" runat="server" CssClass="btn-primary" Text="Swap" OnClick="pressureSwap_Click" />
                </div>
                    </asp:panel>
                </ContentTemplate>
            <triggers>
              <asp:asyncpostbacktrigger controlid="FromListPressure" eventname="SelectedIndexChanged" />                               
             </triggers>
            </asp:UpdatePanel>  
                 </div>

 <div class="col-sm-6">

    <%-- Display For Energy Converter --%>
       <asp:UpdatePanel ID="EnergyPanel" runat="server">
            <ContentTemplate>
                 <asp:panel id="pnlEnergy" runat="server" DefaultButton="btnEnergyCalculate" >
         <asp:Label ID="LabelEnergy" runat="server" Text="Energy" Font-Bold="True" Font-Size="Large" ForeColor="WhiteSmoke"></asp:Label>
         <br />
        <h5 style="color:whitesmoke">From: </h5>
        <asp:TextBox ID="EnergyFrom" CssClass="btn btn-default btn-sm" placeholder="Enter a Value" runat="server" BorderStyle="Inset" Font-Bold="True" ></asp:TextBox>
        <asp:DropDownList ID="EnergyListFrom" CssClass="btn btn-default btn-sm" runat="server" autopostback="true"   Width="115px" OnSelectedIndexChanged="EnergyListFrom_SelectedIndexChanged"    >
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="Joule">Joule</asp:ListItem>
            <asp:ListItem Value="ElectronVolt">ElectronVolt</asp:ListItem>
            <asp:ListItem Value="Calorie">Calorie</asp:ListItem>
        </asp:DropDownList>
        <br />
        <h5 style="color:whitesmoke">To: </h5>
        <asp:TextBox ID="EnergyTo" CssClass="btn btn-default btn-sm" runat="server" BorderStyle="Inset" Font-Bold="True" ReadOnly="True"></asp:TextBox>
        <asp:DropDownList ID="EnergyListTo" CssClass="btn btn-default btn-sm" autopostback="true" runat="server" Width="115px">
            <asp:ListItem style="display:none">Select Value</asp:ListItem>
            <asp:ListItem Value="Joule">Joule</asp:ListItem>
            <asp:ListItem Value="ElectronVolt">ElectronVolt</asp:ListItem>
            <asp:ListItem Value="Calorie">Calorie</asp:ListItem>
        </asp:DropDownList>
        <br />
                <asp:Label ID="EnergyResponse" runat="server" Font-Bold="true" ForeColor="WhiteSmoke"></asp:Label>
                <br />
                <div class="energyButton">
                    <asp:Button ID="btnEnergyCalculate" runat="server" Text="Calculate"  CssClass="btn-primary" OnClick="btnEnergyCalculate_Click"      />    
                    <asp:Button ID="btnEnergyReset" runat="server" Text="Reset"  CssClass="btn-primary" OnClick="btnEnergyReset_Click"    />         
                    <asp:Button ID="energySwap" runat="server" CssClass="btn-primary" Text="Swap" OnClick="energySwap_Click" />
                </div>
                     </asp:panel>
                </ContentTemplate>
            <triggers>
              <asp:asyncpostbacktrigger controlid="EnergyListFrom" eventname="SelectedIndexChanged" />                               
             </triggers>
            </asp:UpdatePanel>  
               </div>
    </div>
      </div>
</asp:Content>
