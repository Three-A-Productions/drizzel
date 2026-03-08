{pkgs ? import <nixpkgs> {}}:
pkgs.mkShell {
  nativeBuildInputs = with pkgs; [
    zsh
    gcc
    dotnet-sdk
    omnisharp-roslyn
    csharpier
    mono
  ];

  shellHook = ''
    echo -e "\033[1;32mWelcome to the Drizzel development environment!\033[0m"
    echo -e "\033[1;34mAvailable aliases:\033[0m"

    zsh
  '';
}
