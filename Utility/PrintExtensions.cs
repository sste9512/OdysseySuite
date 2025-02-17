﻿using Spectre.Console;
using Spectre.Console.Rendering;

namespace Utility;

public static class PrintExtensions
{
    public static void PrintProperties(this object obj, string content)
    {
        // Render panel borders
        var type = obj.GetType();

        HorizontalRule(type.Name);
        PanelBorders(type.Name, content);

        // Render table borders
        /*HorizontalRule("Properties");
        TableBorders();*/
    }

    private static void PanelBorders(string title, string content)
    {
        static IRenderable CreatePanel(string name, string content,  BoxBorder border)
        {
            return
                new Panel(content)
                    .Header($" [blue]{name}[/] ", Justify.Center)
                    .Border(border)
                    .BorderStyle(Style.Parse("grey"));
        }

        var items = new[]
        {
            CreatePanel(title,  content, BoxBorder.Ascii)
        };
        
        /*
        var items = new[]
        {
            CreatePanel("Ascii", BoxBorder.Ascii),
            CreatePanel("Square", BoxBorder.Square),
            CreatePanel("Rounded", BoxBorder.Rounded),
            CreatePanel("Heavy", BoxBorder.Heavy),
            CreatePanel("Double", BoxBorder.Double),
            CreatePanel("None", BoxBorder.None),
        };
        */

        AnsiConsole.Write(
            new Padder(
                new Columns(items).PadRight(2),
                new Padding(2, 0, 0, 0)));
    }

    private static void TableBorders(this object obj)
    {
        /*static IRenderable CreateTable(string name, TableBorder border)
        {
            var table = new Table().Border(border);
            table.ShowRowSeparators();
            table.AddColumn("[yellow]Property 1[/]", c => c.Footer("[grey]Footer 1[/]"));
            table.AddColumn("[yellow]Header 2[/]", col => col.Footer("[grey]Footer 2[/]").RightAligned());

            var props = obj.GetType().GetProperties();
            table.AddRow("", "Cell");
            table.AddRow("Cell", "Cell");

            return new Panel(table)
                .Header($" [blue]{name}[/] ", Justify.Center)
                .PadBottom(1)
                .NoBorder();
        }*/

        var items = new[]
        {
            CreateTable("Ascii", TableBorder.Ascii), CreateTable("Ascii2", TableBorder.Ascii2),
            CreateTable("AsciiDoubleHead", TableBorder.AsciiDoubleHead),
            CreateTable("Horizontal", TableBorder.Horizontal), CreateTable("Simple", TableBorder.Simple),
            CreateTable("SimpleHeavy", TableBorder.SimpleHeavy), CreateTable("Minimal", TableBorder.Minimal),
            CreateTable("MinimalHeavyHead", TableBorder.MinimalHeavyHead),
            CreateTable("MinimalDoubleHead", TableBorder.MinimalDoubleHead),
            CreateTable("Square", TableBorder.Square), CreateTable("Rounded", TableBorder.Rounded),
            CreateTable("Heavy", TableBorder.Heavy), CreateTable("HeavyEdge", TableBorder.HeavyEdge),
            CreateTable("HeavyHead", TableBorder.HeavyHead), CreateTable("Double", TableBorder.Double),
            CreateTable("DoubleEdge", TableBorder.DoubleEdge), CreateTable("Markdown", TableBorder.Markdown),
        };

        AnsiConsole.Write(new Columns(obj.CreateTable(TableBorder.Ascii)).Collapse());
    }

    private static IRenderable CreateTable(this object obj, TableBorder border)
    {
        var table = new Table().Border(border);
        table.ShowRowSeparators();
        table.AddColumn("[yellow]Property 1[/]", c => c.Footer("[grey]Footer 1[/]"));
        table.AddColumn("[yellow]Header 2[/]", col => col.Footer("[grey]Footer 2[/]").RightAligned());

        var props = obj.GetType().GetProperties();

        foreach (var p in props)
        {
            table.AddRow(p.Name, p.GetValue(obj).ToString());
        }

        return new Panel(table)
            .Header($" [blue]{obj.GetType().FullName}[/] ", Justify.Center)
            .PadBottom(1)
            .NoBorder();
    }

    private static void HorizontalRule(string title)
    {
        AnsiConsole.WriteLine();
        AnsiConsole.Write(new Rule($"[white bold]{title}[/]").RuleStyle("grey").LeftJustified());
        AnsiConsole.WriteLine();
    }
}