
	<center><h1>Контейнери в Qt</h1></center>
        <br>
        <p>Qt надає свої реалізації рядків, контейнерів і алгоритмів в якості спрощеної кроссплатформенной альтернативи для STL.</p>
        <p>Як і в STL, контейнери Qt використовують шаблони C ++ і дозволяють зберігати елементи потрібного типу. Наприклад, QLinkedList &lt;T> - шаблон зв'язного списку; якщо потрібно зв'язний список цілих чисел, то використовується QLinkedList &lt;int>.</p>
        <p>Для контейнерів застосовується неявне поділ пам'яті. Передача контейнерів у вигляді аргументів і їх повернення не пов'язані з витратами, так як копія буде створюватися лише при необхідності зміни одного з об'єктів:</p>
        <pre><code class="cpp"> QList< T > list1;   

           QList< T > list2;   

           list1 << a << b << c; // елементи a, b, c заносяться в list1   

           list2 = list1; // вміст списків збігається   

           list2[0] = d; // тепер list1 копіюється;   

           // list2 змінений, але не list1   </code></pre>
        <p>По можливості, краще передавати const-посилання, так як в цьому випадку змін гарантовано не буде.</p>
        <p>У всіх контейнерів є деякі загальні методи:</p>
        <pre><code class="cpp"> int size () const; // число елементів   

           void clear (); // видалити всі елементи   

           bool isEmpty () const; // true, якщо size () == 0   </code></pre>
        <p>Також всюди перевантажені оператори порівняння == і! =. Мається на увазі, що для типу елементів буде перевантажений оператор ==. Контейнери з послідовним зберіганням елементів порівнюються з урахуванням порядку, інші контейнери порядок не враховують.</p>
        <h2>Контейнери з послідовним зберіганням елементів</h2>
        <p>Для початку розглянемо контейнери QList &lt;T>, QVector &lt;T> і QLinkedList &lt;T>.</p>
        <p>Для додавання елементів до такого контейнера або для об'єднання контейнерів можна використовувати оператори +, + =, &lt;&lt;:</p>
        <pre><code class="cpp">QList< int > xs, ys, zs, us;   

           // (Працює аналогічно для QVector і QLinkedList.)   

           xs << 1 << 2 << 3;   

           // xs = (1,2,3)   

           ys += 1;   

           ys += 2;   

           ys += 3;   

           // ys = (1,2,3)   

           zs = xs + ys;   

           // zs = (1,2,3,1,2,3)   

           us << xs << ys << zs;   

           // us = (1,2,3,1,2,3,1,2,3,1,2,3) </code></pre>
        <p>У цих контейнерах виділяються перший і останній елементи. Посилання на них можна отримати за допомогою first () і last ():</p>
        <pre><code class="cpp">T& first();   

           const T& first() const;   

           T& last();   

           const T& last() const;</code></pre>
        <p>(Для сумісності з STL підтримуються також імена методів front () і back ().)</p>
        <p>Перш ніж викликати ці методи, переконайтеся, що контейнер не порожній.</p>
        <p>Також можна звірити значення першого або останнього елемента:</p>
        <pre><code class="cpp">  bool startsWith (const T& val) const;   
        bool endsWith (const T& val) const;  </code></pre>
        <p>Пошук елементів:</p>
        <pre><code class="cpp"> bool contains (const T & val) const; // міститься val в контейнері?   
        int count (const T & val) const; // кількість входжень   </code></pre>
        <p>Додавання і видалення:</p>
        <pre><code class="cpp"> void prepend (const T & val); // додати val в початок   

           void push_front (const T & val); // теж саме   

           void append (const T & val); // додати val в кінець   

           void push_back (const T & val); // теж саме     

           void pop_front (); // видалити перший елемент   

           void pop_back (); // видалити останній елемент  </code></pre>
        <p>Для вставки і видалення використовуються ітератори. Поки ми тільки перелічимо відповідні методи, але якщо ви не знаєте, що таке ітератори і як вони працюють, то докладні пояснення містяться в останньому розділі.</p>
        <pre><code class="cpp">iterator insert (iterator before, const T & val);   

           // вставити перед позицією before,   

           // повернути итератор, який вказує на вставлене значення   

           iterator erase (iterator pos);   

           // видалити елемент в позиції pos,   

           // повернути итератор, який вказує на наступний елемент   

           iterator erase (iterator begin, iterator end);   

           // видалити елементи в інтервалі [begin, end) (виключаючи end),   

           // повернути итератор, який вказує на end </code></pre>
        <p>Далі будуть розглянуті відмінності між QList &lt;T>, QVector &lt;T> і QLinkedList &lt;T>.</p>
        <h2>Контейнери з доступом за індексом</h2>
        <p>QList &lt;T> і QVector &lt;T> використовують доступ за індексом за постійний час O (1). Як і в масивах C ++, елементи нумеруються з 0.</p>
        <p>Доступ за індексом:</p>
        <pre><code class="cpp">const T& at (int i) const;   

           T& operator[] (int i);   

           const T& operator[] (int i) const;   

           T value (int i) const;   

           T value (int i, const T& defaultValue) const;   </code></pre>
        <p>Заміна значення за індексом:</p>
        <pre><code class="cpp">   void replace (int i, const T& val)</code></pre>
        <p>При зверненні до елементів за індексом перевіряйте, що індекс лежить в інтервалі [0, size ()).</p>
        <p>Пошук індексу:</p>
        <pre><code class="cpp">  int indexOf (const T & val, int from = 0) const;   

           // індекс першого входження val, починаючи з from;   

           // -1, якщо елемент не знайдений   

           int lastIndexOf (const T & val, int from = -1) const;   

           // індекс останнього входження val, починаючи з from   

           // (пошук в зворотному порядку, при from = -1 - з кінця);   

           // -1, якщо елемент не знайдений   </code></pre>
        <p>Вставка в даній позиції:</p>
        <pre><code class="cpp"> void insert (int i, const T& val); </code></pre>
        <p>Якщо потрібно копіювати n елементів з середини, починаючи з позиції pos, то використовується mid (pos, n). При n = -1 елементи копіюються до кінця:</p>
        <pre><code class="cpp"> QList< T > mid (int pos, int length = -1) const;   
         QVector< T > mid (int pos, int length = -1) const;   </code></pre>
        <h2>QList</h2>
        <p>QList &lt;T> - найбільш часто використовуваний контейнер.</p>
        <p>Додавання візуального ефекту в середину списку здійснюється за O (n). Для вставки за постійний час в Qt є зв'язний список QLinkedList.</p>
        <p>Амортизоване час вставки елементів в початок і в кінець - O (1).</p>
        <p>Особливі методи QList &lt;T>:</p>
        <pre><code class="cpp"> T QLinkedList :: takeFirst (); // повернути перший елемент і видалити   

           T QLinkedList :: takeLast (); // повернути останній елемент і видалити   

           void QList :: removeFirst (); // видалити перший елемент   

           void QList :: removeLast (); // видалити останній елемент   

           void QList :: removeAt (int i); // видалити i-й елемент   

           T QList :: takeAt (int i); // повернути i-й елемент і видалити   

           bool QList :: removeOne (const T & val); // видалити перше входження   

           int QList :: removeAll (const T & val); // видалити всі входження   

           void move (int from, int to); // відповідає insert (to, takeAt (from))   

           void swap (int i, int j); // обміняти i-е і j-е значення</code></pre>
        <p>Приклад роботи зі списком:</p>
        <pre><code class="cpp"> QList< int > list;   

           list << 0 << 1 << 2 << 3;   

           // (0, 1, 2, 3)   

           list.swap (1,2);   

           // (0, 2, 1, 3)   

           list.move (0,2);   

           // (2, 1, 0, 3)   

           list.removeAt (1);   

           list.removeAt (1);   

           // (2, 3)   </code></pre>
        <h2>QVector</h2>
        <p>QVector &lt;T> - це звичайний динамічний масив. Його має сенс використовувати, якщо елементи повинні зберігатися в одній ділянці пам'яті.</p>
        <p>При використанні вектора можна отримати покажчик на дані і звертатися з ними як зі звичайним масивом:</p>
        <pre><code class="cpp"> T* QVector::data();   

           const T* QVector::data() const;   

           const T* QVector::constData() const; </code></pre>
        <p>Звичайно, покажчики діють тільки до тих пір, поки вміст не буде переміщено в пам'яті.</p>
        <p>При створенні вектора можна вказати розмір і инициализирующее значення:</p>
       <pre><code class="cpp"> QVector::QVector (int size = 0, const T& val = T());   </code></pre>
        <p>Якщо потім буде потрібно знову ініціювати вектор, то використовується fill ():</p>
        <pre><code class="cpp"> QVector < T > & QVector :: fill (const T & val); // форматувати   

        QVector < T > & QVector :: fill (const T & val, int n); // змінити розмір,форматувати  </code></pre>
        <p>Крім числа елементів size (), у вектора є ємність - загальний зарезервований обсяг.</p>
        <pre><code class="cpp"> int QVector::capacity() const;</code></pre>
        <p>Число елементів змінюється за допомогою resize ():</p>
        <pre><code class="cpp"> void QVector::resize (int size);   </code></pre>
        <p>Ємність змінюється за допомогою reserve ():</p>
        <pre><code class="cpp"> void QVector::reserve (int n); </code></pre>
        <p>Ємність можна встановлювати, якщо заздалегідь відомо максимальне число елементів. Якщо ємності не вистачить для збільшення розміру на деякому етапі, то це лише торкнеться швидкодію.</p>
        <p>Невикористовувана пам'ять звільняється за допомогою squeeze ():</p>
        <pre><code class="cpp"> void QVector::squeeze();   </code></pre>
        <p>Як і reserve (), цей метод може знадобитися в рідкісних випадках при оптимізації коду.</p>
        <p>Видалення і вставка в векторі:</p>
        <pre><code class="cpp">  QVector < T > :: iterator QVector :: insert (iterator before, int count, const T & val);   

           // вставити кілька копій val перед before   

           void QVector :: insert (int i, int count, const T & val);   

           // вставити кілька копій val в позиції i   

           void QVector :: remove (int i); // видалити i-й елемент   

           void QVector :: remove (int i, int n);   

           // видалити n елементів, починаючи з i-го   </code></pre>
        <p>Приклад роботи з вектором:</p>
        <pre><code class="cpp">QVector< int > vec(5,23);   

           // 23, 23, 23, 23, 23   

           for (int i = 0; i < vec.size(); i++)   

             vec[i] = i;   

           // 0, 1, 2, 3, 4   

           vec.resize(10);   

           // 0, 1, 2, 3, 4, 0, 0, 0, 0, 0   

           vec.data (); // покажчик на перший елемент  </code></pre>
        <h2>QLinkedList</h2>
        <p>QLinkedList &lt;T> - зв'язний список. Він відрізняється від QList &lt;T> тим, що при роботі для доступу до елементів потрібно використовувати ітератори. При цьому вставка елементів в середину відбувається за постійний час O (1) і не призводить до псування ітератора, що вказує на деякий інший елемент. Доступ за індексом здійснюється за O (n).</p>
        <p>Специфічні методи QList &lt;T>:</p>
        <pre><code class="cpp"> T QLinkedList :: takeFirst (); // повернути перший елемент і видалити   

           T QLinkedList :: takeLast (); // повернути останній елемент і видалити   

           void QLinkedList :: removeFirst (); // видалити перший елемент   

           void QLinkedList :: removeLast (); // видалити останній елемент   

           bool QLinkedList :: removeOne (const T & val); // видалити всі входження   

           int QLinkedList :: removeAll (const T & val); // видалити перше входження   </code></pre>
        <p>Приклад роботи із зв'язковим списком:</p> 
        <pre><code class="cpp"> T QLinkedList :: takeFirst (); // повернути перший елемент і видалити   

           T QLinkedList :: takeLast (); // повернути останній елемент і видалити   

           void QLinkedList :: removeFirst (); // видалити перший елемент   

           void QLinkedList :: removeLast (); // видалити останній елемент   

           bool QLinkedList :: removeOne (const T & val); // видалити всі входження   

           int QLinkedList :: removeAll (const T & val); // видалити перше входження   </code></pre>  
        <h2>Стек і черга</h2>
        <h2>QStack</h2>
        <p>Стек (LIFO) QStack &lt;T> реалізований через успадкування від QVector &lt;T> з додаванням наступних методів:</p>
        <pre><code class="cpp">T & QStack :: top (); // верхній елемент   

           const T & QStack :: top () const;   

           T QStack :: pop (); // зняти верхній елемент   

           void QStack :: push (const T & x); // покласти елемент зверху </code></pre>
        <p>Перш ніж брати елемент, переконайтеся, що стек не порожній (! Stack.isEmpty ()).</p>
        <p>Приклад роботи зі стеком:</p>
        <pre><code class="cpp"> QStack< QString > stack;   

           stack.push("D");   

           stack.push("N");   

           stack.push("A");   

           // (D, N, A)   

           stack.pop(); // A   

           // (D, N)   

           stack.pop(); // N   

           // (D)   

           stack.push("M");   

           stack.push("T");   

           // (D, M, T)   

           while (!stack.isEmpty()) // зняти всі елементи з стека   

           {   

           qDebug() << stack.pop();   

           }   </code></pre>
        <h2>QQueue</h2>
        <p>Черга (FIFO) QQueue &lt;T> реалізована через успадкування від QList &lt;T> з додаванням наступних методів:</p>
        <pre><code class="cpp">  T & QQueue :: head (); // головний елемент   

           const T & QQueue :: head () const;   

           T QQueue :: dequeue (); // взяти головний елемент   

           void QQueue :: enqueue (const T & x); // додати елемент в хвіст   </code></pre>
        <p>Перш ніж брати елемент, переконайтеся, що черга не порожня (! Queue.isEmpty ()).</p>
        <p>Приклад роботи з чергою:</p>
        <pre><code class="cpp">  T & QQueue :: head (); // головний елемент   

           const T & QQueue :: head () const;   

           T QQueue :: dequeue (); // взяти головний елемент   

           void QQueue :: enqueue (const T & x); // додати елемент в хвіст   </code></pre>
        <h2>Контейнери з доступом по ключу</h2>
        <h2>QHash</h2>
        <p>QHash &lt;K, T> - хеш-таблиця, яка відображає ключі типу K в значення типу T.</p>
        <p>Амортизоване час пошуку і вставки - O (1).</p>
        <p>Якщо потрібно структура, в якій елементи зберігаються відсортованими по ключу, використовуйте QMap &lt;K, T>.</p>
        <p>Додавання елементів:</p>
        <pre><code class="cpp">  T & QQueue :: head (); // головний елемент   

           const T & QQueue :: head () const;   

           T QQueue :: dequeue (); // взяти головний елемент   

           void QQueue :: enqueue (const T & x); // додати елемент в хвіст   </code></pre>
        <p>insert (key, val) прив'язує значення val за ключем key. Якщо такий ключ вже є, то значення заміщається. Якщо потрібно зберігати кілька значень для одного ключа, використовуйте insertMulti (key, val). Крім того, у QHash &lt;K, T> є спеціальний дочірній клас QMultiHash &lt;K, T>.</p>
        <p>Якщо потрібно повністю вставити вміст іншої хеш-таблиці, використовуйте unite ():</p>
       <pre><code class="cpp">  T & QQueue :: head (); // головний елемент   

           const T & QQueue :: head () const;   

           T QQueue :: dequeue (); // взяти головний елемент   

           void QQueue :: enqueue (const T & x); // додати елемент в хвіст   </code></pre>
        <p>Якщо поточна хеш-таблиця вже містить певний ключ, то в результуючій таблиці він буде дублюватися.</p>
        <p>Доступ до значень по ключу:</p>
        <pre><code class="cpp">  T & QQueue :: head (); // головний елемент   

           const T & QQueue :: head () const;   

           T QQueue :: dequeue (); // взяти головний елемент   

           void QQueue :: enqueue (const T & x); // додати елемент в хвіст   </code></pre>
        <p>Можна також отримати ключі за значеннями, але хеш-таблиці не оптимізована для роботи в цьому напрямку, тому час пошуку буде лінійним.</p>
        <pre><code class="cpp">  const K QHash::key (const T& val) const;   

           const K QHash::key (const T& val, const K& defaultKey) const;   

           QList < K > QHash :: keys () const; // всі ключі   

           QList < K > QHash::keys (const T& val) const;   

           QList < K > QHash :: uniqueKeys () const; // без повторень </code></pre>
        <p>Якщо ключ не знайдений, то повертається значення за замовчуванням K (). Також можна використовувати метод</p>
        <pre><code class="cpp">const T QHash::value (const K& key, const T& defaultValue) const;</code></pre>
        <p> - він повертає defaultValue, якщо ключа немає.</p>
        <p>Пошук елементів:</p>
       <pre><code class="cpp"> bool QHash :: contains (const K & key) const; // чи є ключ key?   

           int QHash :: count (const K & key) const; // число входжень   

           QHash < K, T > :: iterator QHash :: find (const K & key);   

           QHash < K, T > :: const_iterator QHash :: find (const K & key) const;   

           QHash < K, T > :: const_iterator QHash :: constFind (const K & key) const;  </code></pre>
        <p>Якщо ключу відповідає кілька значень, то повертається итератор, який вказує на останній доданий елемент; якщо цей итератор інкрементіровать, то можна отримати інші значення. Якщо елемент не знайдений, то повертається итератор end ().</p>
        <p>Видалення по Ітератор і по ключу:</p>
        <pre><code class="cpp">QHash < K, T > :: iterator QHash :: erase (QHash < K, T > :: iterator pos);   

           // повертається итератор вказує на наступний елемент   

           int QHash :: remove (const K & key);   

           // повертає число віддалених елементів  </code></pre>
        <h2>QMultiHash</h2>
        <p>QMultiHash &lt;K, T> успадковує QHash &lt;K, T> і орієнтований на структури, в яких одному ключу може відповідати кілька значень. метод</p>
       <pre><code class="cpp"> QHash hash;   

           hash.insert("02-16", "Cremation Wednesday");   

           hash.insert("02-23", "The Feast of St Monty Python");   

           hash.insert("02-29", "Quaternary Prolapse begins");   

           hash.insert("04-01", "The Feast of Saint Eris");   

           hash.insertMulti("04-01", "Bob's Birthday");   

           hash.remove("02-29");   

           //видалить запис   

           // 02-29 => Quaternary Prolapse begins   

           hash.value("04-01", "slack"); // "Bob's Birthday"   

           hash.value("01-01", "slack"); // "slack"   

           hash.key("The Feast of St Monty Python"); // "02-23" </code></pre>
        <p>завжди додає новий елемент, навіть якщо ключ повторюється. Щоб замінити наявне значення при повторенні ключів, потрібно викликати</p>
        <pre><code class="cpp">  QHash< K,T >::iterator QMultiHash::insert (const K& key, const T& val);   </code></pre>
        <p>Також додаються методи для пошуку і видалення елементів, які беруть, крім ключа, відповідне значення:</p>
        <pre><code class="cpp">   QHash< K,T >::iterator replace (const K& key, const T& val);  </code></pre>
        <p>Для злиття хеш-таблиць перевантажені оператори + і + =:</p>
        <pre><code class="cpp">  bool contains (const K& key, const T& val) const;   

           int count (const K& key, const T& val) const;   

           QHash< K,T >::iterator QMultiHash::find (const K& key, const T& val);   

           QHash< K,T >::const_iterator QMultiHash::find (const K& key, const T& val) const;   

           QHash< K,T >::const_iterator QMultiHash::constFind (const K& key, const T& val) const;   

           int QMultiHash::remove (const K& key, const T& val); </code></pre>
        <h2>QMap</h2>
        <p>QMap &lt;K, T> - асоціативний масив, що відображає ключі типу K в значення типу T.</p>
        <p>Елементи упорядковано відповідно до ключу (для чого потрібно перевантаження operator <()), і прохід по QMap завжди дає вміст в відсортованому порядку.</p>
        <p>Пошук і вставка здійснюються за логарифмічна час O (log n).</p>
        <p>Якщо елементи не потрібно сортувати по ключам, то використовуйте QHash &lt;K, T>.</p>
        <p>Інтерфейс QMap &lt;K, T> практично збігається з QHash &lt;K, T>. Є додаткові функції для пошуку елементів по ключам:</p>
        <pre><code class="cpp"> QMap< K,T >::iterator QMap::lowerBound (const K& key);   

           QMap< K,T >::const_iterator QHash::lowerBound (const K& key) const;   

           QMap< K,T >::iterator QHash::upperBound (const K& key);   

           QMap< K,T >::const_iterator QHash::upperBound (const K& key) const;   </code></pre>
        <p>lowerBound (key) повертає ітератор, який вказує на перший елемент з ключем key. Якщо такого ключа немає, то повертається итератор, який вказує на найближчий елемент з великим ключем.</p>
        <p>upperBound (key) повертає ітератор, який вказує на останній елемент з ключем key. Якщо такого ключа немає, то повертається итератор, який вказує на найближчий елемент з великим ключем.</p>
        <p>Таким чином, всі елементи з даними ключем лежать в інтервалі [lowerBound, upperBound].</p>
        <p>приклад:</p>
        <pre><code class="cpp">  QMultiMap< QString,QString > map;   

           map.insert("02-16", "Cremation Wednesday");   

           map.insert("02-23", "The Feast of St Monty Python");   

           map.insert("02-29", "Quaternary Prolapse begins");   

           map.insert("04-01", "The Feast of Saint Eris");   

           map.insert("04-01", "Bob's Birthday");   

           map.lowerBound ("02-16"); // вказує на ("02-16", "Cremation Wednesday")   

           map.lowerBound ("02-17"); // вказує на ("02-23", "The Feast of St Monty Python")   

           map.lowerBound ("05-23"); // вказує на end ()   

           QMap< QString,QString >::const_iterator lb = map.lowerBound("04-01");   

           QMap< QString,QString >::const_iterator ub = map.upperBound("04-01");   

           while (lb != ub)   

           {   

           qDebug() << lb.value();   

           lb++;   

           }   

           // Виводить   

           // "Bob's Birthday"   

           // "The Feast of Saint Eris"   </code></pre>
        <p>QMultiMap &lt;K, T> успадковує QMap &lt;K, T> і орієнтований на структури, в яких одному ключу може відповідати кілька значень.</p>
        <p>Інтерфейс QMultiMap &lt;K, T> практично повністю відповідає QMultiHash &lt;K, T>.</p>
        <h2>Множини</h2>
        <p>QSet &lt;T> - неврегульована множина, заснована на хеш-таблиці. Множина дозволяє швидко отримувати і додавати значення:</p>
       <pre><code class="cpp"> bool QSet::contains (const T& val) const;   

           // міститься елемент val в множині?   

           QSet< T >::iterator QSet::find (const T& val);   

           // знайти val; якщо елемент не знайдений, повернути end ()   

           QSet< T >::const_iterator QSet::find (const T& val) const;   

           QSet< T >::const_iterator QSet::constFind (const T& val) const;   

           QSet< T >::iterator QSet::erase (iterator pos);   

           // видалити значення в даній позиції   

           QSet< T >& QSet::operator<< (const T& val);   

           QSet< T >::const_iterator QSet::insert (const T& val);   

           // додасть елемент   

           bool QSet::remove (const T& val); // видалить елемент   

           QList< T > QSet::values() const; // список елементів  </code></pre>
        <p>Особливий інтерес представляють операції об'єднання, перетину і різниці:</p>
        <pre><code class="cpp">QSet< T >& QSet::unite (const QSet< T >& other);   

           QSet< T >& QSet::intersect (const QSet< T >& other);   

           QSet< T >& QSet::subtract (const QSet< T >& other);</code></pre>
        <p>Для тих же цілей перевантажені оператори:</p>
        <pre><code class="cpp">  // Об'єднання:   

           QSet< T > QSet::operator+ (const QSet< T >& other) const;   

           QSet< T >& QSet::operator+= (const QSet< T >& other);   

           QSet< T >& QSet::operator+= (const T& val);   

           // Перетин:   

           QSet< T > QSet::operator& (const QSet< T >& other) const;   

           QSet< T >& QSet::operator&= (const QSet< T >& other);   

           QSet< T >& QSet::operator&= (const T& val);   

           // Різниця:   

           QSet< T > QSet::operator- (const QSet< T >& other) const;   

           QSet< T >& QSet::operator-= (const QSet< T >& other);   

           QSet< T >& QSet::operator-= (const T& val);</code></pre>
        <p>Приклад роботи з множинами:</p>
        <pre><code class="cpp"> QSet x, y, z, u, v, w;   

           x << "a" << "b" << "c" << "d" << "e"; // {a,b,c,d,e}   

           y << "b" << "d"; // {b,d}   

           z << "b" << "c"; // {b,c}   

           u = y+z; // {b,d} + {b,c} = {b,c,d}   

           v = y&z; // {b,d} & {b,c} = {b}   

           w = x - u; // {a,b,c,d,e} - {b,c,d} = {a,e}</code></pre>	
        <script type="text/javascript">hljs.initHighlightingOnLoad();</script>
       