

namespace Mobile.Snapfat.Views;

public partial class MasterView : ContentPage
{

	public List<Post> ImagesList = new(){
		new Post{
			ID=1,
			Likes= 341,
			Title="Embrace the Sun: Your Ultimate Guide to a Blissful Summer in Hawaii",
			Content="Hawaii in the summer is nothing short of paradise—a perfect blend of sun, surf, and serenity. Imagine waking up to the sound of waves gently caressing the shore, the scent of plumeria flowers filling the air, and the warmth of the sun kissing your skin. Start your day with a refreshing dip in the crystal-clear waters of Waikiki Beach, where the ocean invites you to surf, snorkel, or simply float in its turquoise embrace. /n As the day unfolds, explore the lush, vibrant landscapes that define the islands. Hike through the verdant rainforests of Kauai, where towering waterfalls cascade into hidden pools, or venture to the volcanic wonders of the Big Island, where you can witness the earth’s raw power at Hawaii Volcanoes National Park. Don’t miss the chance to experience the rich culture of Hawaii—attend a traditional luau, where the rhythm of the hula and the flavors of local cuisine will captivate your senses. /n When the sun begins to set, Hawaii transforms into a place of sheer magic. Find a spot on the beach to watch the sky explode into a kaleidoscope of colors, with hues of pink, orange, and purple reflecting off the ocean. As night falls, gather around a bonfire with friends, sharing stories and laughter under a sky dotted with stars. Hawaii in the summer is more than just a destination—it’s a state of mind, a place where time slows down and every moment is infused with aloha. Embrace the beauty, adventure, and spirit of Hawaii this summer, and create memories that will last a lifetime.",
			ImageUrl="https://plus.unsplash.com/premium_photo-1681930101084-b388dc06d91f?q=80&w=3087&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
		},
		new Post{
			ID=2,
			Likes= 98,
			Title="Unleash the Magic of Homemade Cookies: A Journey of Flavor",
			Content="Creating homemade cookies is a magical experience! Begin by preheating your oven, filling your kitchen with warmth and anticipation. Cream butter and sugar until fluffy, then add vanilla and eggs, mixing until smooth. Slowly fold in flour, a pinch of salt, and chocolate chips for that irresistible gooeyness. Drop spoonfuls of dough onto a baking sheet, ensuring perfect spacing. Bake until golden, your home filled with the sweet aroma of nostalgia. Share with loved ones or savor the moment alone—each bite a taste of blissful comfort!",
			ImageUrl="https://plus.unsplash.com/premium_photo-1670938559615-b46f987731f2?q=80&w=3087&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
		},
		new Post{
			ID=3,
			Likes= 200,
			Title="The Power of Play: Embrace Your Gaming Journey",
			Content="There’s something undeniably captivating about holding a game controller—it’s not just a piece of hardware; it’s a gateway to countless worlds, challenges, and adventures. Whether you’re diving into epic quests, competing in fierce battles, or simply unwinding with a casual game, that controller in your hand symbolizes limitless possibilities. It’s the connection between you and the game, where every move, decision, and strategy is at your fingertips. In that moment, the world fades away, and you’re fully immersed in the experience, driven by the thrill of what’s next. Embrace the power of play, and let the journey begin!",
			ImageUrl="https://images.unsplash.com/photo-1542549237432-a176cb9d5e5e?w=900&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1yZWxhdGVkfDE5fHx8ZW58MHx8fHx8"
		},
		new Post{
			ID=4,
			Likes= 33,
			Title="The Craft of Code: Shaping the Digital World One Line at a Time",
			Content="In the quiet hum of the office, where creativity meets precision, developers immerse themselves in the craft of coding. Each line of code is more than just text—it’s a building block of the digital experiences that shape our world. With focused eyes on their screens, these modern-day artisans work tirelessly to solve problems, create innovative solutions, and push the boundaries of technology. It’s a process that demands patience, logic, and a touch of creativity. The end result? Powerful software, seamless applications, and the backbone of the digital age. In a world where everything is becoming digital, the role of a developer is more crucial than ever, transforming ideas into reality, one line of code at a time.",
			ImageUrl="https://images.unsplash.com/photo-1536148935331-408321065b18?q=80&w=3087&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
		},
	};

	public MasterView()
	{
		// MasterViewModel model
		// BindingContext = model;
		InitializeComponent();

		var displayInfo = DeviceDisplay.MainDisplayInfo;
		double width = displayInfo.Width;
		double height = displayInfo.Height;
		double density = displayInfo.Density;

		double widthInDip = width / density;
		double heightInDip = height / density;

		MainCarouselView.WidthRequest = widthInDip;
		MainCarouselView.HeightRequest = heightInDip;

		Random random = new Random();
		ImagesList = ImagesList.OrderBy(x => random.Next()).ToList();
		MainCarouselView.ItemsSource = ImagesList;
		//CarouselIndicator.RotateTo(90);
	}
}