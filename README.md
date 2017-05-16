# SingersWebApi
## Что это
Бекэнд для [business_react_boilerplate](https://github.com/klishevich/business_react_boilerplate)
## Как запустить
* Сперва нужно установить [.NET Core SDK](https://www.microsoft.com/net/download/core)
* Перейти в папку с проектом
* Выполнить команды:
  * `dotnet restore`
  * `dotnet build`
  * `dotnet run`
## Как отлаживать

В [Visual Studio 2017](https://www.visualstudio.com/ru/vs/whatsnew/)
* Открыть SingersWebApi.sln
* В меню: `Debug -> Start Debugging`

В [Visual Studio Code](https://code.visualstudio.com/)
* Установить плагин [C#](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
   * Ctrl + P `ext install csharp`
* Открыть папку с проектом
* В меню: `Debug -> Start Debugging`

## Где хранятся данные
В памяти. 
  
Если нужно добавить больше начальных данных, добавьте их в файл [ListsContext.cs](./ListsContext.cs)
