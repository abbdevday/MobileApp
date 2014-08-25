using DevDay.Mobile.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevDay.Mobile.DataSources
{
    class SessionRepository
    {
        private static List<Session> sessions;

        private static List<AgendaItem> agenda;

        private static void InitSessions()
        {
            if (sessions != null)
            {
                return;
            }

            sessions = new List<Session>();

            sessions.Add(new Session()
            {
                Title = "Registration",
                Timeslot = "8:00 - 9:00"
            });

            sessions.Add(new Session()
            {
                Title = "Welcome Session",
                Timeslot = "9:00 - 9:20"
            });

            sessions.Add(new Session()
            {
                Title = "Software Architecture vs Code",
                Speaker = "Simon Brown",
                Description = "Software architecture and coding are often seen as mutually exclusive disciplines, despite us referring to higher level abstractions when we talk about our software. You've probably heard others on your team talking about components, services and layers rather than objects when they're having discussions. Take a look at the codebase though. Can you clearly see these abstractions or does the code reflect some other structure? If so, why is there no clear mapping between the architecture and the code? Why do those architecture diagrams that you have on the wall say one thing whereas your code says another? In fact, why is it so hard to automatically generate a decent architecture diagram from an existing codebase? Join us to explore this topic further.",
                TagLine = "Author of \"Software Architecture for Developers\"",
                Bio = "Simon lives in Jersey (the largest of the Channel Islands) and works as an independent consultant, helping teams to build better software. His client list spans over 20 countries and includes organisations ranging from small technology startups through to global household names. Simon is an award-winning speaker and the author of Software Architecture for Developers - a developer-friendly guide to software architecture, technical leadership and the balance with agility. He still codes too.",
                Image = "simon.png",
                Timeslot = "9:20 - 10:10"
            });

            sessions.Add(new Session()
            {
                Title = "Coffee!",
                Timeslot = "10:10 - 10:40"
            });

            sessions.Add(new Session()
            {
                Title = "Defensive Programming 101 v5 - Common Security Mistakes in Web Applications",
                Speaker = "Niall Merrigan",
                Description = "The web is a funny old place. You create a wonderful application, deploy it for the world to see and then everybody just wants to break it. This session will show you some of the common security mistakes made by developers and how to avoid them. There will be (possibly frightening) demos with code in C#. Talk is rated level 200-300 with a target audience of web developers (not just ASP.NET. All the examples will be done in .NET. Even if you are not a web developer some of the parts of the talk will be handy) and assumes knowledge of web programming, basic security concepts, a working brain and sense of humour.",
                TagLine = "Irish man lost in Norway",
                Bio = "Niall is an Irish guy who managed to end up in Norway after finding out the country existed when he was in New Zealand. He works in Capgemini in Stavanger, Norway as their Head of Custom Software Development, and is also an Microsoft ASP.NET MVP since 2010, Friend Of RedGate and general rugby nut (which means he shouts a lot). He has a passion for web technologies, security and whiskey which can lead to some interesting discussions. He can be found on twitter as @nmerrigan and hosts a blog at http://www.certsandprogs.com",
                Image = "niall.png",
                Timeslot = "10:40 - 11:30"
            });

            sessions.Add(new Session()
            {
                Title = "Why No Code Reviews?",
                Speaker = "Enrico Campidoglio",
                Description = "It’s undisputed that regular peer reviews are one of the most effective ways to maintain high quality in a code base. Yet, so many development teams choose not to adopt them for their software project. In the publishing industry, no written word ever sees the light of day before it has gone through an extensive period of critical review. This applies to books, scientific papers and newspaper articles alike. Why not software?\n\nIn this session we’ll explore the social and practical reasons why code reviews aren’t as widely adopted in modern software development shops as they should be. We’ll also look at a few concrete tools and techniques that teams can put in place to help them overcome the most common road blocks. In the end, we’ll see how code reviews help peers leverage each other’s knowledge and skills to ensure their work is as good as it can possibly be.",
                TagLine = "tretton37",
                Bio = "Enrico is a programmer who combines a strong passion for quality with a mild OCD. He has spent over a decade in the Microsoft and Java camps, striving to write simple and expressive code in whatever language he happens to be using. He’s also a technical trainer and a speaker, who regularly presents at conferences and user groups on topics such as Object-oriented design, Test-driven development, Continuous Deployment and, sometimes, mechanical keyboards.\n\nEnrico is a core contributor to AutoFixture, an open source library for .NET that helps alleviate some of the friction experienced when doing Test-driven development by making it easier to generate test data.\n\nEnrico works at tretton37 and can be found blogging on megakemp.com or tweeting at @ecampidoglio.",
                Image = "enrico.png",
                Timeslot = "10:40 - 11:30"
            });

            sessions.Add(new Session()
            {
                Title = "Coffee again!",
                Timeslot = "11:30 - 11:50"
            });

            sessions.Add(new Session()
            {
                Title = "So Long, and Thanks for All the Tests",
                Speaker = "Seb Rose",
                Description = "TDD has long been recommended by agile practitioners, but the community still argues about how to go about it. Inside-out or outside-in? Mockist or classical? Through a component's public API or for every class? And then there's Kent Beck's famous quote: “I get paid for code that works, not for tests, so my philosophy is to test as little as possible to reach a given level of confidence.” This introduces a further level of subjectivity, especially since developers are frequently overconfident.\n\nIn this session, Seb will explore the choices that agile teams need to make when considering which development practices to adopt. He'll look again at some of the arguments for the different approaches and urge teams to practice until you're happy with the way you code.",
                TagLine = "For Examples",
                Bio = "An independent software developer, trainer and consultant based in the UK. He specialises in working with teams adopting and refining their agile practices, with a particular focus on automated testing.\n\nSince he first worked as a programmer in 1980 (writing applications in compiled BASIC on an Apple II) he has dabbled in many technologies for many companies, including Linn Smart, Amazon and IBM. He is writing \"The Cucumber-JVM Book\" for the Pragmatic Programmer's.",
                Image = "seb.png",
                Timeslot = "11:50 - 12:40"
            });

            sessions.Add(new Session()
            {
                Title = "Hacking the Mind: How Art Can Help Us Talk (and Teach) Technology",
                Speaker = "Qi",
                Description = "The world of software development is changing at an increasingly rapid pace, leaving developers with less time to learn new tools and paradigms, and hardly any time to convey that knowledge to others. How do we convince our managers to change course? How do we bring other developers up to speed? And if things go wrong, how do we explain it to our non-technical customers without losing their trust? Qi will talk about the relationship between art and code, and how we can use the principles of fiction, music, poetry and painting to present complex information to any audience without confusing or -- worse -- boring them to tears.",
                TagLine = "The Codeless Code",
                Bio = "Qi (not his real name) has been a professional software developer since the days of the Apple II, and an amateur writer and artist since he was first able to hold a crayon. By day he works mostly as a designer/developer of Java-based Enterprise systems, but by night he may be found writing or illustrating the latest installment of The Codeless Code. Qi has a passion for teaching, and has always considered mentoring the best part of leading a team. Although the exaggerated cruelty in some of his stories might lead you to think otherwise, Qi is really quite gentle, and almost never administers fatal beatings.",
                Image = "qi.png",
                Timeslot = "11:50 - 12:40"
            });

            sessions.Add(new Session()
            {
                Title = "Lunch Ladies & Gentlemen!",
                Timeslot = "12:40 - 13:50"
            });

            sessions.Add(new Session()
            {
                Title = "React + NPM for Great Good",
                Speaker = "Rob Ashton",
                Description = "Frameworkless development with NPM is great - but patching together odd templating libraries and managing the DOM can end up causing performance issues if the team is not careful to batch updates across components. That's where React comes in - utilizing React as a view engine within a typical framework-less set-up can result in cheap performance gains and a sensible data management strategy throughout the app without any of that horrific two-way data binding found in other systems.\n\nSee now as Rob covers how he uses React within a typical application set-up, build tools, common patterns, common modules and patterns for easy wins for the entire team.",
                TagLine = "Professional Naysayer",
                Bio = "Rob finds himself leaping from technology to technology, striving to put right what once went wrong, and hoping each time that his next leap will be the leap to something he actually likes.",
                Image = "rob.png",
                Timeslot = "13:50 - 14:40"
            });

            sessions.Add(new Session()
            {
                Title = "Learning to Think \"The Designer Way\"",
                Speaker = "Ben Hall",
                Description = "The best way to annoy a designer is to tell them that a red block should be blue, that a piece of text should be moved over, or to make the logo bigger without any motivation or reasoning. The best way to give constructive feedback is to have evidence based on the site flow, design goals, visual principles and user behaviour to support the problems that you see with the design.\n\nTo provide this you need to start thinking like a designer. In this session Ben will discuss how to start thinking like a designer, the core principals of design that affect our opinions of applications on a sub-concussion level based on the key design principles and how to start defining potential solutions the designer way. Alongside this Ben will also attempt to provide answers to the “blank canvas” problem and how you can go from nothing to something, an activity that designers seem to do without even thinking. As companies and communities embrace full-stack developers it’s time to start including design within that stack and not just a single person’s responsibility.",
                TagLine = "Unicorn, Hipster, Founder",
                Bio = "Ben has done the rounds as a tester, developer, speaker, freelancer, startup entrepreneur and most recently working at a startup investment company in London. Ben is currently working on his next venture.",
                Image = "ben.png",
                Timeslot = "13:50 - 14:40"
            });

            sessions.Add(new Session()
            {
                Title = "Moar coffee",
                Timeslot = "14:40 - 15:00"
            });

            sessions.Add(new Session()
            {
                Title = "Hacking Your Doorbell",
                Speaker = "Karl-Henrik Nillson",
                Description = "The internet of Things is a pretty big things by now and shows no sign of stopping - in fact over the last year the \"buzz\" about IoT have increased fivefolded and the .NET community is going to find loads of work in this Area.\n\nBut the problem is that we currently don't have a good middle place for aspiring developers that just want to build something cool, the developers that are not in IoT projects and are looking to dive in, learn and create home IoT projects.\n\nI have been creating network connected items for a long time and never really understood why the fact that my doorbell could be muted with a click of a button in my WindowsPhone was such a big deal to my developer friends, especially since it was nothing more to it than a 433 Mhz transmitter pair, an mCU and a transistor to it.\n\nWe need to get it out there to all our super skilled developers that hacking hardware and connecting the physical world to our computers is cheap, easy and fun!\n\nThis talk asserts the possible technology choices such as Arduino, Netduino, AVR and some other interesting choices, how basic reverse engineering of existing hardware is done (analysis, tools for analysis etc) and how to get started hacking hardware in a Microsoft/C# .NET (well mostly) environment TODAY!",
                TagLine = "Senior developer/Software architect of Sogeti",
                Bio = "Karl-Henrik is an experienced developer that have written code for anything from cellular network base stations to websites.\nHe runs the local Microsoft competence network at Sogeti and spend a somewhat obsessive amount of his free time building smarter devices.\n\"If you ever need to see a man about building a smarter toaster - I'm that guy\"",
                Image = "karl.png",
                Timeslot = "15:00 - 15:50"
            });

            sessions.Add(new Session()
            {
                Title = "Art of Saying NO",
                Speaker = "Kasia Mrowca",
                Description = "What to do when app requirements are „without any sense”? You might try to defend yourself from doing nonsense by estimating this accordingly (infinity sounds like correct estimate ;))… This strategy is tricky though! Despite high estimates client might still decide to do feature in “not the wisest manner” and make you miserable by the way.\n\nHowever, there is another way! Presentation will reveal the secret of art of saying no and expressing disagreement in a firm but user-friendly manner (or friendly enough to not been thrown away from window or fired).",
                TagLine = "Geek Girl",
                Bio = "Kasia is an IT, management & agile passionate. For Kasia sky is the limit, so she moved to the clouds… and aviation business. Currently she works for a factory producing billions of lines of code which magically turn into working software.",
                Image = "kasia.png",
                Timeslot = "15:00 - 15:50"
            });

            sessions.Add(new Session()
            {
                Title = "Well, just another break",
                Timeslot = "15:50 - 16:10"
            });

            sessions.Add(new Session()
            {
                Title = "It Doesn't Work That Way in Enterprise",
                Speaker = "Peter Smith",
                Description = "We've all heard it... or something similar. There's probably one senior guy at work who tells you this at least once a month. You've got an idea for an amazing new feature or practice that's going to save your company both time and money, but it's too 'cutting edge'; your management fears the unfamiliar and you are cruelly stifled.\n\n\"It doesn't work like that in Enterprise\" is a passionate and motivational story about my journey as a developer in the face of one of the worst fallacies in our industry. The extremes of my experience will make you laugh & cry in equal measure, and maybe help put your own frustrations into perspective. Just remember, it does get better... and you probably got off very f***g lightly!",
                TagLine = "ASP.NET & Distributed Systems Consultant",
                Bio = "Pete is a software consultant based in London with almost 10 years of experience making web applications with ASP.net, specialising in API design, JavaScript applications and distributed systems. He is the author of Superscribe - a graph based routing framework - and HTTP query library Linq to Querystring among others.",
                Image = "peter.png",
                Timeslot = "16:10 - 17:00"
            });

            sessions.Add(new Session()
            {
                Title = "What is DevOps and How It Can Help My Business Succeed?",
                Speaker = "Paul Stack",
                Description = "DevOps is not just a buzzword. DevOps is all about culture. By achieving the right culture, then your engineers can really start to move fast. Moving fast is something that we currently think we do.\n\nDevOps is not about tooling or giving developers root access to production systems.DevOps is about breaking down the communication barriers to allow our entire IT team to work as 1. When the team has a culture of open communication and business understanding, then they can achieve anything!\n\nDuring this talk, Paul will describe what DevOps is and how it is a great way for the entire business to achieve their goals. DevOps is not the new Agile! DevOps is about people :)",
                TagLine = "Opentable",
                Bio = "Paul Stack is a London based Infrastructure Engineer working for OpenTable. Paul has spoken at various events throughout the world about his passion for continuous integration and continuous delivery and why they should be part of what developers do on a day to day basis.\n\nHe believes that reliably delivering software is just as important as its development. Paul’s newest passion is the DevOps movement and how this helps not just development and operations but the entire business and it’s customers.",
                Image = "paul.png",
                Timeslot = "16:10 - 17:00"
            });

            sessions.Add(new Session()
            {
                Title = "Tea Time!",
                Timeslot = "17:00 - 17:30"
            });

            sessions.Add(new Session()
            {
                Title = "Jackstones: The Journey to Mastery",
                Speaker = "Dan North",
                Description = " It takes time to become really good at something. Time, commitment and a genuine passion. If you're not having fun the learning is a chore, if you are then it hardly feels like learning at all, at least not like the thing they made you do in school. Craftsmanship is about making that commitment and then figuring out how to see it through.\n\nUsing examples of mastery from various fields and a thirty year paper-folding habit, Dan describes some of the many facets of craftsmanship and tries to figure out exactly what the craft is that we programmers do.",
                TagLine = "Dan North & Associates",
                Bio = "Dan North uses his deep technical and organisational knowledge to help CIOs, business and software teams to deliver quickly and successfully. He puts people first and finds simple, pragmatic solutions to business and technical problems, often using lean and agile techniques. With over twenty years of experience in IT, Dan is a frequent speaker at technology conferences worldwide. The originator of Behaviour-Driven Development (BDD) and Deliberate Discovery, Dan has published feature articles in numerous software and business publications, and contributed to The RSpec Book: Behaviour Driven Development with RSpec, Cucumber, and Friends and 97 Things Every Programmer Should Know: Collective Wisdom from the Experts. He occasionally blogs at http://dannorth.net/blog.",
                Image = "dan.png",
                Timeslot = "17:30 - 18:20"
            });

            sessions.Add(new Session()
            {
                Title = "Party!",
                Timeslot = "18:30 - ..."
            });
        }

        public static List<Session> GetSessions()
        {
            InitSessions();

            return sessions;
        }

        public static List<AgendaItem> GetAgenda()
        {
            InitSessions();

            if (agenda == null)
            {
                agenda = new List<AgendaItem>();

                string previousTimeslot = "";
                foreach (var session in sessions)
                {
                    if (session.Timeslot != previousTimeslot)
                    {
                        agenda.Add(new AgendaItem { IsTimeslot = true, Name = session.Timeslot });
                    }

                    var item = new AgendaItem { Name = session.Title };
                    if (!string.IsNullOrWhiteSpace(session.Speaker))
                    {
                        item.Session = session;
                    }
                    agenda.Add(item);

                    previousTimeslot = session.Timeslot;
                }
            }

            return agenda;
        }
    }
}
