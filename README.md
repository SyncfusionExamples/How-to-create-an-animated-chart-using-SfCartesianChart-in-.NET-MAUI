# How to create an animated chart using SfCartesianChart in .NET MAUI?
	
The [.NET MAUI Cartesian Chart](https://help.syncfusion.com/maui/cartesian-charts/getting-started) will animate seamlessly in two ways: when you first load the chart or when you redraw it after modifying the data points. This section provides insights into both methods of animating the chart control.

**Steps for Animating a Chart Upon Loading**

We can smoothly animate the chart at loading by setting the [EnableAnimation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableAnimation) property to `True`.

```xml
<chart:SfCartesianChart>
. . .

 <chart:ColumnSeries x:Name="series" ItemsSource="{Binding Data1}" XBindingPath="Month" YBindingPath="Value" EnableAnimation="True">
 </chart:ColumnSeries>

</chart:SfCartesianChart>
```

**Steps for Dynamically Animating the Chart**
The [SfCartesianChart](https://help.syncfusion.com/maui/cartesian-charts/getting-started) provides seamless animation when dynamically changing data points. Follow these steps to achieve dynamic animation in the .NET MAUI Cartesian Chart:

**Step 1:** Initialize and arrange the grid layout according to the desired view.

```xml
<Grid>
 <Grid.RowDefinitions>
  <RowDefinition Height="50"/>
  <RowDefinition Height="*"/>
 </Grid.RowDefinitions>
</Grid>
```

**Step 2:** Configure the Syncfusion .NET MAUI SfCartesianChart control using this [documentation](https://help.syncfusion.com/maui/cartesian-charts/getting-started) and enable series animation.

**Step 3:** Add the button to the layout.

```xml
<Grid>

<Button Grid.Row="0" Text="Add Data Point" Clicked="Animation_Clicked"/>

<chart:SfCartesianChart Grid.Row="1">
. . .

<chart:ColumnSeries x:Name="series" ItemsSource="{Binding Data1}" XBindingPath="Month" YBindingPath="Value" EnableAnimation="True"/>

</chart:SfCartesianChart>

</Grid>
```

**Step 4:** Change the ItemsSource collection in the button-clicked event.

```csharp
private void Animation_Clicked(object sender, EventArgs e)
{
    series.ItemsSource = viewModel.Data2;    
} 
```

**Output:**
![After](https://github.com/SyncfusionExamples/How-to-create-an-animated-chart-using-SfCartesianChart-in-.NET-MAUI/assets/103025761/b6573fc8-e200-4190-bbc2-4caff832e9a3)

## Troubleshooting
### Path too long exception
If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For more details, refer to the KB on [how to create an animated chart (SfCartesianChart) in .NET MAUI](https://support.syncfusion.com/kb/article/14943/how-to-create-an-animated-chart-sfcartesianchart-in-net-maui-)
