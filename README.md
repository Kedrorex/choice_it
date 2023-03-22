```mermaid
graph TD;
subgraph Основная логика
    A("START")-->B[\"Print (Включить тестовую работу - 1) 
    Print (Включить ручной ввод - 2) 
    Print (Введите команду: )"/]

    B-->C[/"string valve = Convert.ToString(Console.ReadLine())" /]

    C-->D{"valve = 1 || valve = 2"}

    D--"no"-->E[\" Print (Неправильный ввод!)"/]

    D--"yes"-->F[/"int number = Convert.ToInt32(valve)
    int size = 4
    string[] sortikol = StageSelection(number)"/]

    F-->I["sortikol = StringRangeFilter(sortikol, size)"]

    I-->G[\"Print (Отфильтрованый массив:)
    Print (sortikol)"/]

    G-->L["END"]
    end


    
    subgraph StageSelection 
    
    AS[/" int index = number"/]-->BS{"Switch (index)"} 

    BS--> CS[\"Print (Тестовый массив: )"/]
    BS--> MS[\"Print (Введите строки через пробел: )"/]
    BS-->NS[/"string[] temp = {  }"/]

    subgraph case 1
    CS-->ES[/"string[] temp1 = { ABSD, 123, GB, покемон, _^$^, #@# }"/]
    ES-->DS[\"Print (temp1)"/]
    DS-->GS["return (temp1)"]
    end
    
    subgraph case 2
        MS-->LS[/"string? test = Convert.ToString(Console.ReadLine())
        string[] temp2 = test.Split(new char[] { ' ' })"/]
        LS-->TS[\"Print (temp2)"/]
        TS-->KS["return (temp2)"]
    end

     subgraph default
        NS-->PS["return (temp)"]
     end
    end

    subgraph StringRangeFilter 
        AR[/"int size = 0
        string bufer 
        int i = 0"/]
        AR-->BR{"i < temp.Length;"}
        BR--no-->GR["bufer = bufer.Trim(new char[] { ' ' })"]
        GR-->TR[/"string[] result = bufer.Split(new char[] { ' ' })"/]
        TR-->ER["return result"]
        BR--yes-->YR["size = temp[i].Length"]
        YR-->JR{"size < range"}
        JR--yes-->PR["bufer += temp[i] + "_""]
        PR-->IR[i++]
        IR-->BR
        JR--no-->IR
    end

    F-->AS
    GS-->F
    KS-->F
    PS-->F
    I-->AR
    ER-->I
```    