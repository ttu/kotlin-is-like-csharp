doctype

html
  head
    title "Kotlin is like C#"
    meta (:charset utf-8)
    link (:rel stylesheet) (:href css/style.css)
    link (:rel stylesheet) (:href css/highlightjs-github.css)
    script (:src js/highlight.pack.js)
    script "hljs.initHighlightingOnLoad();"

  body
    a (:target _blank)
      :href https://github.com/ttu/kotlin-is-like-csharp
      img#fork-me (:src https://github.blog/wp-content/uploads/2008/12/forkme_right_red_aa0000.png?resize=149%2C149)
    #note
      = "Kotlin is like C#"
     
    .disclaimer "Comparing syntax of Kotlin and C#. Don't take language likeness too seriously."
    .disclaimer "Fixes, improvents and additions are welcome. Open an issue or a PR."
    .section
      .title BASICS
      .case (.name "Hello World") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/hello-world.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/hello-world.cs)
      .case (.name "Variables and Constants") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/variables-and-constants.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/variables-and-constants.cs)
      .case (.name "Explicit Types") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/explicit-types.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/explicit-types.cs)
      .case (.name "Type Coercion") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/type-coercion.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/type-coercion.cs)
      .case (.name "Compile Time Constants") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/compiletime-constants.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/compiletime-constants.cs)
      .case (.name "String Interpolation") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/string-interpolation.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/string-interpolation.cs)
      .case (.name "If Expression / Statement") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/if-statement.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/if-statement.cs)
      .case (.name "Conditionals") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/conditional.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/conditional.cs)

    .section
      .title FUNCTIONS
      .case (.name "Functions") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/functions.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/functions.cs)
      .case (.name "Named Arguments") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/named-arguments.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/named-arguments.cs)
      .case (.name "Default Arguments") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/default-arguments.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/default-arguments.cs)
      .case (.name "Variable Number of Arguments") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/variable-number-of-arguments.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/variable-number-of-arguments.cs)
      .case (.name "Tuple Return") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/tuple-return.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/tuple-return.cs)
      .case (.name "Function Type / Delegates") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/function-type.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/function-type.cs)

    .section
      .title COLLECTIONS
      .case (.name "Arrays") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/arrays.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/arrays.cs)
      .case (.name "Lists") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/lists.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/lists.cs)
      .case (.name "Maps / Dictionaries") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/maps.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/maps.cs)
      .case (.name "Empty Collections") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/empty-collections.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/empty-collections.cs)
      .case (.name "Range Operator") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/range-operator.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/range-operator.cs)
      .case (.name "Inclusive Range Operator") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/inclusive-range-operator.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/inclusive-range-operator.cs)
      .case (.name "Collection Range and Index") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/range-and-index.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/range-and-index.cs)

    .section
      .title "COLLECTION OPERATIONS"
      .case (.name "Map") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/map.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/map.cs)
      .case (.name "Sort") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/sort.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/sort.cs)
      .case (.name "Filter / GroupBy / Average") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/collections.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/collections.cs)

    .section
      .title CLASSES
      .case (.name "Declaration") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/class-declaration.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/class-declaration.cs)
      .case (.name "Usage") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/usage.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/usage.cs)
      .case (.name "Subclass") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/subclass.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/subclass.cs)
      .case (.name "Data Class") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/data-class.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/data-class.cs)
      .case (.name "Immutable Data Class") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/immutable-data-class.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/immutable-data-class.cs)
      .case (.name "Extensions / Extension Methods") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/extension-methods.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/extension-methods.cs)
      .case (.name "Interfaces") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/interface.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/interface.cs)

    .section
      .title TYPES
      .case (.name "Checking Type") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/checking-type.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/checking-type.cs)
      .case (.name "Casting") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/casting.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/casting.cs)
      .case (.name "Smart Cast") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/smart-casting.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/smart-casting.cs)

    .section
      .title "PATTERN MATCHING"
      .case (.name "When / Switch Expression") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/pattern-matching.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/pattern-matching.cs)
      .case (.name "Is Expression / When Clause / Property Pattern") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/pattern-matching-2.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/pattern-matching-2.cs)

    .section
      .title NULL
      .case (.name "Nullable Types") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/null-reference.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/null-reference.cs)
      .case (.name "Null Conditional") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/null-conditional.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/null-conditional.cs)
      .case (.name "Elvis Operator / Null Coalescing") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/null-coalescing.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/null-coalescing.cs)
      .case (.name "Dynamic, Out and Conditional") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/dynamic-conditional.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/dynamic-conditional.cs)

    .section
      .title "COROUTINES / TASKS"
      .case (.name "Async / Await") $ .pair
        .card (.lang Kotlin) $ pre.code $ code (@insert ../code/coroutines-tasks.kt)
        .card (.lang C#) $ pre.code $ code (@insert ../code/coroutines-tasks.cs)
