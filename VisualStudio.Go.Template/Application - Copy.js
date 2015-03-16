
// Handle the startup event for the ShellUI environment.
function OnNewShellUI( shellUI ) {

    shellUI.Events.OnNewShellFrame = function ( shellFrame ) {

        shellFrame.ShowMessage( {
            caption: "M-Files Application1",
            message: "Hello world!"
        } );

    };
}

// Handle the startup event for the VaultUI environment.
function OnNewVaultUI( vaultUI ) {
}

// Handle the startup event for the VaultCore environment.
function OnNewVaultCore( vaultCore ) {
}
