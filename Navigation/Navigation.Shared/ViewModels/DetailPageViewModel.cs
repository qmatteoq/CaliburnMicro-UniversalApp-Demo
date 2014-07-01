using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using Navigation.Entities;

namespace Navigation.ViewModels
{
public class DetailPageViewModel: Screen
{
    public Movie Parameter { get; set; }

    private string title;

    public string Title
    {
        get { return title; }
        set
        {
            title = value;
            NotifyOfPropertyChange(() => Title);
        }
    }

    protected override void OnActivate()
    {
        Title = Parameter.Title;
    }
}
}
