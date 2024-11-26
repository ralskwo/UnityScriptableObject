# [Unity] 스크립터블 오브젝트(Scriptable Object): 게임 데이터를 효율적으로 관리하는 방법

## 개요

유니티의 **스크립터블 오브젝트(Scriptable Object)**는 게임 데이터를 효율적으로 관리하기 위한 강력한 도구입니다. 이 프로젝트는 Scriptable Object를 활용하여 게임 데이터를 체계적으로 관리하고, 재사용성을 극대화하며, 프로젝트 유지보수성을 향상시키는 방법을 다룹니다. Scriptable Object의 기본 개념부터 실제 적용 사례까지 포함되어 있어, Unity 프로젝트에서 효율적인 데이터 관리를 구현하는 데 도움을 줄 것입니다.

---

## 주요 기능

- **Scriptable Object 생성 및 관리**: 독립적인 데이터 관리와 Unity Editor를 통한 간편한 수정.
- **데이터 재사용성**: 여러 씬과 오브젝트에서 동일한 데이터를 공유하여 메모리 효율성 극대화.
- **적용 사례**: 아이템 정보, 캐릭터 스탯, 레벨 설정 등의 데이터 관리.
- **이벤트 시스템**: 게임 이벤트 데이터를 중앙에서 관리.
- **런타임 데이터 관리**: Scriptable Object의 런타임 수정 및 저장 팁 제공.

---

## 설치 및 실행

### 1. Unity 프로젝트 설정

- Unity **2022.3.40f1**(또는 그 이상) 버전을 사용하세요.

### 2. Scriptable Object 생성

- 프로젝트 내 `Scripts` 폴더에 제공된 스크립트를 추가합니다.
- Unity Editor에서 **우클릭 > Create > [Custom Category]**를 통해 Scriptable Object 에셋을 생성합니다.

---

## 사용법

### 1. Scriptable Object 클래스 정의

아래 코드를 참고하여 Scriptable Object 클래스를 정의하세요.

```csharp
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public int itemID;
    public Sprite itemIcon;
}
```

### 2.에셋 생성 및 데이터 입력

1. Unity Editor에서 우클릭 > Create > Inventory > Item을 선택합니다.
2. 생성된 .asset 파일에서 데이터를 입력합니다.

### 3. Scriptable Object 데이터 사용

다음 코드를 참고하여 Scriptable Object 데이터를 참조하고 사용합니다.

```csharp
using UnityEngine;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    public ItemData itemData;
    public TextMeshProUGUI itemNameText;

    void Start()
    {
        itemNameText.text = itemData.itemName;
    }
}
```

---

## Scriptable Object의 장점

- **효율적인 데이터 관리**: 데이터를 독립적으로 관리하고, 코드를 단순화하여 유지보수성을 높입니다.
- **데이터 재사용성**: 여러 오브젝트와 씬에서 동일한 데이터를 참조할 수 있어 메모리 효율성을 제공합니다.
- **편리한 팀 협업**: 비개발자도 Unity Editor를 통해 데이터를 쉽게 수정 가능.

---

## 주의사항

1. **런타임 데이터 저장**

   - Scriptable Object는 런타임 수정 사항이 영구적으로 저장되지 않습니다. 필요한 경우 JSON 파일이나 데이터베이스를 사용해 데이터를 저장하세요.

2. **직렬화 제한**

   - 복잡한 데이터 구조나 순환 참조가 있는 경우 직렬화 이슈가 발생할 수 있습니다. 설계 단계에서 이를 고려하세요.

3. **데이터 변경 전파**
   - Scriptable Object는 모든 참조된 오브젝트에 동일한 데이터를 제공하므로, 변경 시 의도치 않은 영향을 미칠 수 있습니다.

---

## 기여

이 프로젝트는 Unity를 활용한 효율적인 데이터 관리를 배우고자 하는 개발자들에게 유용합니다. 새로운 아이디어나 개선 사항이 있다면 자유롭게 기여해주세요!

---

## 라이선스

이 프로젝트는 MIT 라이선스에 따라 배포됩니다. 자유롭게 사용하되, 원작자를 명시해주세요.

---

## 문의

궁금한 점이 있다면 언제든 문의해주세요!

- **Email**: [ralskwo@gmail.com](mailto:ralskwo@gmail.com)
- **GitHub**: [ralskwo](https://github.com/ralskwo)
