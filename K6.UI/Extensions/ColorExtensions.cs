using K6.UI.Enums;

namespace K6.UI.Extensions;

internal static class ColorExtensions
{
    internal static string? ToAlertClass(this Color color)
    {
        return color switch
        {
            Color.Primary => "alert-primary",
            Color.Secondary => "alert-secondary",
            Color.Success => "alert-success",
            Color.Danger => "alert-danger",
            Color.Warning => "alert-warning",
            Color.Info => "alert-info",
            Color.Light => "alert-light",
            Color.Dark => "alert-dark",
            _ => null
        };
    }

    internal static string? ToBadgeClass(this Color color)
    {
        return color switch
        {
            Color.Primary => "bg-primary",
            Color.Secondary => "bg-secondary",
            Color.Success => "bg-success",
            Color.Danger => "bg-danger",
            Color.Warning => "bg-warning",
            Color.Info => "bg-info",
            Color.Light => "bg-light",
            Color.Dark => "bg-dark",
            _ => null
        };
    }

    internal static string? ToBorderClass(this Color color)
    {
        return color switch
        {
            Color.Primary => "border-primary",
            Color.Secondary => "border-secondary",
            Color.Success => "border-success",
            Color.Danger => "border-danger",
            Color.Warning => "border-warning",
            Color.Info => "border-info",
            Color.Light => "border-light",
            Color.Dark => "border-dark",
            _ => null
        };
    }

    internal static string? ToButtonClass(this Color color, ButtonVariant? variant)
    {
        return color switch
        {
            Color.Primary => variant switch
            {
                ButtonVariant.Solid => "btn-primary",
                ButtonVariant.Outline => "btn-outline-primary",
                ButtonVariant.Link => "btn-link",
                _ => null
            },
            Color.Secondary => variant switch
            {
                ButtonVariant.Solid => "btn-secondary",
                ButtonVariant.Outline => "btn-outline-secondary",
                _ => null
            },
            Color.Success => variant switch
            {
                ButtonVariant.Solid => "btn-success",
                ButtonVariant.Outline => "btn-outline-success",
                _ => null
            },
            Color.Danger => variant switch
            {
                ButtonVariant.Solid => "btn-danger",
                ButtonVariant.Outline => "btn-outline-danger",
                _ => null
            },
            Color.Warning => variant switch
            {
                ButtonVariant.Solid => "btn-warning",
                ButtonVariant.Outline => "btn-outline-warning",
                _ => null
            },
            Color.Info => variant switch
            {
                ButtonVariant.Solid => "btn-info",
                ButtonVariant.Outline => "btn-outline-info",
                _ => null
            },
            Color.Light => variant switch
            {
                ButtonVariant.Solid => "btn-light",
                ButtonVariant.Outline => "btn-outline-light",
                _ => null
            },
            Color.Dark => variant switch
            {
                ButtonVariant.Solid => "btn-dark",
                ButtonVariant.Outline => "btn-outline-dark",
                _ => null
            },
            _ => null
        };
    }

    internal static string? ToLinkClass(this Color color)
    {
        return color switch
        {
            Color.Primary => "link-primary",
            Color.Secondary => "link-secondary",
            Color.Success => "link-success",
            Color.Danger => "link-danger",
            Color.Warning => "link-warning",
            Color.Info => "link-info",
            Color.Light => "link-light",
            Color.Dark => "link-dark",
            _ => null
        };
    }

    internal static string? ToTextClass(this Color color)
    {
        return color switch
        {
            Color.Primary => "text-primary",
            Color.Secondary => "text-secondary",
            Color.Success => "text-success",
            Color.Danger => "text-danger",
            Color.Warning => "text-warning",
            Color.Info => "text-info",
            Color.Light => "text-light",
            Color.Dark => "text-dark",
            _ => null
        };
    }

    internal static string? ToBgClass(this Color color)
    {
        return color switch
        {
            Color.Primary => "bg-primary",
            Color.Secondary => "bg-secondary",
            Color.Success => "bg-success",
            Color.Danger => "bg-danger",
            Color.Warning => "bg-warning",
            Color.Info => "bg-info",
            Color.Light => "bg-light",
            Color.Dark => "bg-dark",
            _ => null
        };
    }

    internal static string? ToTextBgClass(this Color color)
    {
        return color switch
        {
            Color.Primary => "text-bg-primary",
            Color.Secondary => "text-bg-secondary",
            Color.Success => "text-bg-success",
            Color.Danger => "text-bg-danger",
            Color.Warning => "text-bg-warning",
            Color.Info => "text-bg-info",
            Color.Light => "text-bg-light",
            Color.Dark => "text-bg-dark",
            _ => null
        };
    }

    internal static string? ToNavbarClass(this Color color)
    {
        return color switch
        {
            Color.Primary => "bg-body-primary",
            Color.Secondary => "bg-body-secondary",
            Color.Success => "bg-body-success",
            Color.Danger => "bg-body-danger",
            Color.Warning => "bg-body-warning",
            Color.Info => "bg-body-info",
            Color.Light => "bg-body-light",
            Color.Dark => "bg-body-dark",
            _ => null
        };
    }
}