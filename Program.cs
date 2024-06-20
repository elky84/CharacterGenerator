using CharacterGenerator;

Console.WriteLine("성향 테스트를 시작합니다.");

// 질문 리스트 생성
List<string> questions =
[
    "당신이 레스토랑에 간다면 무엇을 시키겠습니까?",
    "새로운 도시를 방문할 때 가장 먼저 할 일은 무엇인가요?",
    "휴가를 떠난다면 어떤 종류의 장소를 선호하시나요?"
];

// 각 질문에 대한 답변 리스트 생성
List<List<Answer>> answers =
[
    // 질문 1에 대한 답변 리스트
    [
        new("스테이크와 포테이토", new Dictionary<Stat, int> {
            { Stat.Strength, 1 },
            { Stat.Intelligence, 0 },
            { Stat.Dexterity, 0 },
            { Stat.Wisdom, 0 },
            { Stat.Charisma, 1 },
            { Stat.Constitution, 0 }
        }),
        new("샐러드와 생선", new Dictionary<Stat, int> {
            { Stat.Strength, 0 },
            { Stat.Intelligence, 0 },
            { Stat.Dexterity, 1 },
            { Stat.Wisdom, 0 },
            { Stat.Charisma, 1 },
            { Stat.Constitution, 0 }
        }),
        new("피자와 맥주", new Dictionary<Stat, int> {
            { Stat.Strength, 0 },
            { Stat.Intelligence, 1 },
            { Stat.Dexterity, 0 },
            { Stat.Wisdom, 1 },
            { Stat.Charisma, 0 },
            { Stat.Constitution, 0 }
        })
    ],

    // 질문 2에 대한 답변 리스트
    [
        new("지역의 유명 랜드마크 방문", new Dictionary<Stat, int> {
            { Stat.Strength, 0 },
            { Stat.Intelligence, 0 },
            { Stat.Dexterity, 0 },
            { Stat.Wisdom, 1 },
            { Stat.Charisma, 1 },
            { Stat.Constitution, 0 }
        }),
        new("로컬 음식 체험", new Dictionary<Stat, int> {
            { Stat.Strength, 0 },
            { Stat.Intelligence, 1 },
            { Stat.Dexterity, 0 },
            { Stat.Wisdom, 0 },
            { Stat.Charisma, 0 },
            { Stat.Constitution, 0 }
        }),
        new("도시의 역사적인 장소 탐방", new Dictionary<Stat, int> {
            { Stat.Strength, 0 },
            { Stat.Intelligence, 0 },
            { Stat.Dexterity, 1 },
            { Stat.Wisdom, 0 },
            { Stat.Charisma, 0 },
            { Stat.Constitution, 0 }
        })
    ],

    // 질문 3에 대한 답변 리스트
    [
        new("해변 리조트", new Dictionary<Stat, int> {
            { Stat.Strength, 0 },
            { Stat.Intelligence, 0 },
            { Stat.Dexterity, 1 },
            { Stat.Wisdom, 0 },
            { Stat.Charisma, 1 },
            { Stat.Constitution, 0 }
        }),
        new("캠핑장", new Dictionary<Stat, int> {
            { Stat.Strength, 1 },
            { Stat.Intelligence, 0 },
            { Stat.Dexterity, 1 },
            { Stat.Wisdom, 0 },
            { Stat.Charisma, 0 },
            { Stat.Constitution, 0 }
        }),
        new("도심 호텔", new Dictionary<Stat, int> {
            { Stat.Strength, 0 },
            { Stat.Intelligence, 1 },
            { Stat.Dexterity, 0 },
            { Stat.Wisdom, 1 },
            { Stat.Charisma, 0 },
            { Stat.Constitution, 0 }
        })
    ]
];

for (int i = 0; i < questions.Count; i++)
{
    Console.WriteLine($"질문 {i + 1}: {questions[i]}");
    for (int j = 0; j < answers[i].Count; j++)
    {
        Console.WriteLine($"{j + 1}. {answers[i][j].Text}");
    }
    Console.Write("답변을 선택하세요: ");
    int choice = int.Parse(Console.ReadLine() ?? "") - 1;

    ApplyStats(answers[i][choice].Stats);
}

Console.WriteLine("\n최종 스탯:");
PrintStats();

static void ApplyStats(Dictionary<Stat, int> stats)
{
    foreach (var stat in stats)
    {
        Character.Stats[stat.Key] += stat.Value;
    }
}

static void PrintStats()
{
    foreach (var stat in Character.Stats)
    {
        Console.WriteLine($"{stat.Key}: {stat.Value}");
    }
}