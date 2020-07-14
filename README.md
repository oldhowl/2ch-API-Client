##Простая имплементация API клиента для [2ch.hk](https://2ch.hk)   
[Официальное описание API](https://2ch.hk/api/index.html)

####Инжектим сервис:
    
    services.AddWakaba2ChApiClient();
    
####Пользуемся:

    var threadsFromBoard = await _wakaba2ChApi.Client.GetAllThreadsFromBoardLite("b");  

    foreach (var thread in threadsFromBoard.Threads.OrderByDescending(x => x.Score))  
    {  
      Console.WriteLine($"Тред: {thread.Subject}");  
      Console.WriteLine($"Просмотров: {thread.Views}");  
      Console.WriteLine($"Текст: {thread.Comment}");  
      Console.WriteLine($"Ответов: {thread.PostsCount}");  
      Console.WriteLine(Environment.NewLine);  
    }

Так же можно заинжектить отдельно общий или мобильный клиент.

    services.AddWakaba2ChApiMobile();
    services.AddWakaba2ChApi();
    
_Если нужно достучаться до API через прокси, передайте в билд инжекта подготовленный HttpClientHanlder_

    services.AddWakaba2ChApiClient(new HttpClientHandler { Proxy = proxy });



#### На данный момент реализовано (выделено жирным):

> JSON для тредов и списков:   
>
> Треды:  
> **http(s)://2ch.hk/доска/res/номертреда.json   Список тредов:  
> http(s)://2ch.hk/доска/номерстраницы.json (первая страница: index)**  
> 
> **Все треды с сортировкой по последнему посту:  
> http(s)://2ch.hk/доска/catalog.json**  
> 
> **Все треды с сортировкой по времени создания треда: 
>   http(s)://2ch.hk/доска/catalog_num.json**  
>   
> **Все треды с доски(облегченный вариант, с просмотрами и рейтингом для топа тредов):   
> http(s)://2ch.hk/доска/threads.json**      
> 
> Мобильное API   
> 
> **Получить настройки всех досок:  
> Пример:
> http(s)://2ch.hk/makaba/mobile.fcgi?task=get_boards**      
> 
> Получить все посты из треда с номера поста по доске:   
> Пример:
> http(s)://2ch.hk/makaba/mobile.fcgi?task=get_thread&board=abu&thread=39220&num=41955
> 
> Получить все посты из треда с номера поста по треду:   
> Пример:
> http(s)://2ch.hk/makaba/mobile.fcgi?task=get_thread&board=abu&thread=39220&post=252
> 
> Получить один пост:   
> 
> Пример:
> http(s)://2ch.hk/makaba/mobile.fcgi?task=get_post&board=доска&post=номер_поста
> 
> Работа с капчей:   
> 1) Получить типы капч, включённые на указанной доске:  
> [https://2ch.hk/api/captcha/settings/b](https://2ch.hk/api/captcha/settings/b)
> 
> 2) Получить уникальный id для выбранного типа капчи:  
> [https://2ch.hk/api/captcha/](https://2ch.hk/api/captcha/)%%type%%/id 
> 
> В случае google recaptcha (которая используется сейчас), дальнейшие
> шаги описаны тут:  
> [https://developers.google.com/recaptcha/intro](https://developers.google.com/recaptcha/intro)
