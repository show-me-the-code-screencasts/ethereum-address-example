# ethereum-address-example

Przykład kodu ze screencasta dostępnego pod adresem https://youtu.be/-9EN9pXQboc, link do posta https://krzysztofmorcinek.wordpress.com/2019/06/14/przyklad-na-zamykanie-rozproszonej-funkcjonalnosci-do-wlasciwego-typu-screencast/

Rozwinęliśmy przykład z ostatniego odcinka (Jak tworzyć dedykowane wrappery do prostych typów) i w praktyce przenieśliśmy funkcjonalność ze statycznych Utilsów do właściwego typu EthereumAddress.
Przykładem jest address w Ethereum (zmienione na potrzeby przejrzystości;) który najpierw był trzymany jako string a później został upgrade’owany do EthereumAddress (jakby wrapper). Koronnym przykładem jest porównywanie adresów, które pozwala unikać pomyłek.
