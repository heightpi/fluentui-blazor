﻿using Microsoft.AspNetCore.Components;

namespace Microsoft.Fast.Components.FluentUI;

/// <summary />
public partial class MessageBox : IDialogContentComponent<MessageBoxContent>
{
    [Parameter]
    public MessageBoxContent Content { get; set; } = default!;

    [CascadingParameter]
    public FluentDialog Dialog { get; set; } = default!;
}