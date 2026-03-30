# Getting Started with Windows Forms Sparkline

This sample demonstrates how to create and customize a Syncfusion® WinForms Sparkline Chart control.

## Prerequisites

- Visual Studio 2022 or later
- .NET 10.0 or later
- Syncfusion® `Syncfusion.Chart.Windows` NuGet package

## Assembly Deployment

To use the Sparkline control, add the **Syncfusion.Chart.Windows** NuGet package to your project.

Open the **Package Manager Console** and run:

```
Install-Package Syncfusion.Chart.Windows
```

Or, add the reference directly in your `.csproj` file:

```xml
<ItemGroup>
    <PackageReference Include="Syncfusion.Chart.Windows" Version="*" />
</ItemGroup>
```

## Adding Sparkline to the Form

### Step 1: Create a Windows Forms Application

Open Visual Studio, create a new **Windows Forms App** project targeting **.NET 10.0**.

### Step 2: Add the Sparkline Control

In the `Form1.Designer.cs` (or code-behind), initialize and add the `SparkLine` control:

```csharp
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

// Initialize the SparkLine control
this.sparkLine1 = new Syncfusion.Windows.Forms.Chart.SparkLine();

// Set the data source
this.sparkLine1.Source = new double[] { 20, 90, 30, 60, 10, -50, 70, -40, 10 };

// Set the sparkline type
this.sparkLine1.Type = SparkLineType.Line;

// Set size and location
this.sparkLine1.Location = new System.Drawing.Point(55, 48);
this.sparkLine1.Size = new System.Drawing.Size(396, 276);

// Add to the form
this.Controls.Add(this.sparkLine1);
```

## Customizing Sparkline Appearance

The appearance of the sparkline can be customized using the `LineStyle` property:

```csharp
this.sparkLine1.LineStyle.LineColor = System.Drawing.Color.DeepSkyBlue;
```

## Adding Markers to Sparkline

Markers are visual indicators used to represent the location of data points in the sparkline graph. Enable markers using the `ShowMarker` property:

```csharp
this.sparkLine1.Markers.ShowMarker = true;
```

## Highlighting High/Low Values

The marker feature supports `HighPoint`, `LowPoint`, `StartPoint`, `EndPoint`, and `NegativePoint` of the Sparkline. Enable and customize them as shown below:

```csharp
this.sparkLine1.Markers.ShowHighPoint = true;
this.sparkLine1.Markers.ShowLowPoint = true;
this.sparkLine1.Markers.ShowStartPoint = true;
this.sparkLine1.Markers.ShowEndPoint = true;
this.sparkLine1.Markers.ShowNegativePoint = true;

this.sparkLine1.Markers.HighPointColor = new BrushInfo(Color.Blue);
this.sparkLine1.Markers.LowPointColor = new BrushInfo(Color.Green);
this.sparkLine1.Markers.StartPointColor = new BrushInfo(Color.Maroon);
this.sparkLine1.Markers.EndPointColor = new BrushInfo(Color.Purple);
this.sparkLine1.Markers.NegativePointColor = new BrushInfo(Color.Red);
```

## Running the Sample

1. Clone or download this repository.
2. Open `WinFormsSparkline.slnx` in Visual Studio.
3. Restore NuGet packages.
4. Build and run the project (`F5`).

<img width="1919" height="1006" alt="Screenshot 2026-03-30 123227" src="https://github.com/user-attachments/assets/0ccb9be4-cc98-4c29-acbe-2ebfeac6296f" />


## References

- [Syncfusion WinForms Sparkline Documentation](https://help.syncfusion.com/windowsforms/sparkline/gettingstarted)
- [Syncfusion WinForms Sparkline API Reference](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Chart.SparkLine.html)

