**[Sign in to Lab501 VM]{.underline}**

1.  Launch your lab.

2.  Enter the **Username** and **Password** provided in the lab portal.

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image1.png){width="6.5in"
height="3.3201388888888888in"}

**[Authenticate to GitHub Copilot (Required)]{.underline}**

**Complete Enterprise SSO in the Browser**

1.  Open **Microsoft** **Edge**.

2.  Navigate to: https://github.com/enterprises/skillable-events/sso
    **\[GitHub Enterprise SSO landing\]**

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image2.png){width="6.5in"
> height="3.9368055555555554in"}

3.  Click **Continue**.

4.  Sign in with the **Username** and **TAP** provided in the lab
    resources. These values are available under **Resources** tab on the
    right navigation

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image3.png){width="6.5in"
> height="3.8208333333333333in"}

5.  When prompted, approve access (click **Yes**). Dismiss other pop‑ups
    if not required.\
    ![A screenshot of a computer AI-generated content may be
    incorrect.](/mediafolder/media/image4.png){width="6.5in"
    height="3.9611111111111112in"}

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image5.png){width="6.5in"
> height="3.845138888888889in"}

6.  **Do not close** this SSO browser tab.

**Connect GitHub Copilot within Visual Studio**

> 1.Start **Visual Studio 2026** from the desktop/taskbar.
>
> 2\. Open the solution at:
> C:\\Users\\admin\\source\\repos\\devShop\\devShop.sln
>
> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image6.png){width="6.5in"
> height="3.9458333333333333in"}

3.  In **Visual Studio 2026**, open **GitHub Copilot Chat** (View →
    Copilot Chat).\
    ![A screenshot of a computer AI-generated content may be
    incorrect.](/mediafolder/media/image7.png){width="6.5in"
    height="3.9180555555555556in"}

4.  With devShop.sln open, select **Add GitHub Account**.\
    ![A screenshot of a computer AI-generated content may be
    incorrect.](/mediafolder/media/image7.png){width="6.5in"
    height="3.9180555555555556in"}

5.  A browser tab opens; click **Continue** for the user like
    User1-XXXX_skevents.

> **\####** If the SSO tab was closed, repeat **A.1--A.6**, then
> continue here.\
> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image8.png){width="6.5in"
> height="3.8583333333333334in"}

6.  Click **Authorize GitHub** → **Open** (to return to Visual Studio
    2026).\
    ![A screenshot of a computer AI-generated content may be
    incorrect.](/mediafolder/media/image9.png){width="6.5in"
    height="3.9409722222222223in"}

7.  Wait for OAuth to complete (a brief console window may appear).

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image10.png){width="6.5in"
> height="3.8555555555555556in"}

8.  Confirm **GitHub Copilot is authenticated** in Visual Studio 2026.\
    ![A screenshot of a computer AI-generated content may be
    incorrect.](/mediafolder/media/image11.png){width="6.5in"
    height="3.9319444444444445in"}

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image12.png){width="6.5in"
> height="3.9298611111111112in"}

9.  Now, Sign-In to Visual Studio. Click on **Microsoft**

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image11.png){width="6.5in"
> height="3.9319444444444445in"}

10. Click on "**Work or School Account**"![A screenshot of a computer
    AI-generated content may be
    incorrect.](/mediafolder/media/image13.png){width="6.5in"
    height="3.9270833333333335in"}

11. Provide **Username** and **TAP**. These values are available under
    **Resources** tab on the right navigation

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image14.png){width="6.5in"
height="3.9444444444444446in"}

**[Run App Modernization Assessment (GitHub Copilot app modernization
for .NET)]{.underline}**

1.  In **Solution Explorer**, right‑click **devShop** → **Modernize**.

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image15.png){width="6.5in"
> height="3.9180555555555556in"}

2.  You will now be shown **GitHub Copilot Chat** window. In this window
    select "**Migrate to Azure**". This populates the "**Migrate to
    Azure**" prompt in the bottom of the **GitHub Copilot Chat**. Click
    "**Send**"\
    ![A screenshot of a computer AI-generated content may be
    incorrect.](/mediafolder/media/image16.png){width="6.5in"
    height="3.9243055555555557in"}

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image17.png){width="6.5in"
> height="3.932638888888889in"}

3.  Wait for the "**Assessment Report** to be generated.

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image18.png){width="6.5in"
> height="3.845833333333333in"}

4.  **Review** the findings (Registry, Local disk I\\O, Logging,
    Certificate Management, SMTP Migration configuration etc..).

> **\####** Since we are migrating "**devShop**" web application
> (ASP.NET 4.8) to **Managed instance on App Service** we do not require
> to make code change.
>
> It's important to note that these warnings are generated due to
> following code blocks within the "devShop" web application.
>
> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image19.png){width="6.5in"
> height="3.8465277777777778in"}

**\####** SQL Database connection string being read from "Registry"

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image20.png){width="6.5in"
height="3.8131944444444446in"}

**\####** Log4net writing logs to "**h:\\temp\\logs\\log.txt**" and SMTP
delivery to local directory "**K:\\mountfs**"

**[Sign In to Azure Portal]{.underline}**

1.  Open **Microsoft** **Edge** → go to <https://portal.azure.com>

2.  Sign in with the **"Username and Password".** These values are
    available under **Resources** tab on the right navigation. If you
    have existing SSO browser tab open then you may not be required to
    provide credentials.

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image3.png){width="6.5in"
> height="3.8208333333333333in"}

3.  After you are signed in and on the portal homepage; click on the
    "**Resource Groups**" link. On the next page click on
    "**ignite2025**" resource group. ![A screenshot of a computer
    AI-generated content may be
    incorrect.](/mediafolder/media/image21.png){width="6.5in"
    height="3.4611111111111112in"}

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image22.png){width="6.5in"
height="3.473611111111111in"}

4.  You should be able to see all the pre-provisioned resources.

![A computer screen shot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image23.png){width="6.5in"
height="3.845833333333333in"}

[**Migrate "devShop**" web app to **Managed Instances on App
Service.**]{.underline}

**Upload Installation Script to the Storage Account.**

1.  In the Portal, go to the pre‑created **Storage account** starting
    with name **lab01**

2.  Click on "**Storage Browser**" and then click on "**Blob
    containers**"

3.  Click on "**scriptcontainer**".

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image24.png){width="6.5in"
> height="3.277083333333333in"}

4.  Click **Upload**

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image25.png){width="6.5in"
> height="3.2708333333333335in"}

5.  You can "**Drag and Drop**" or "**Browse for files**". The
    installation script is available at
    "**C:\\Users\\Admin\\source\\ASMI_Scripts\\InstallationScript\\installcomponents.zip**"

6.  click **Upload**.

**Create a Managed Instance on App Service Plan.**

1.  Click on **"Create a Resource"** on Azure Portal homepage.

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image26.png){width="6.5in"
> height="3.466666666666667in"}

2.  Now on the Azure Marketplace page type "**web app**" or "**Managed
    Instance**" and press enter.

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image27.png){width="6.5in"
> height="4.76875in"}

3.  On the results page select "**Web App (for Managed
    Instance)(preview)**"

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image28.png){width="6.5in"
> height="3.138888888888889in"}

4.  On the next page click **"create"**

> ![A screenshot of a web application AI-generated content may be
> incorrect.](/mediafolder/media/image29.png){width="6.5in"
> height="6.783333333333333in"}

5.  On the **Basics** tab provide following values and click **Next:
    Advanced**

**Subscription --** Auto populated or select from the dropdown box

**Resource Group --** ignite2025

**Name --** We need to provide unique name for the web app ex:
**Lab501YourFullnameMMDD** (Max length 60 characters)

**Runtime Stack --** ASP.NET V4.8

**Region --** Should be same as the Azure region for the ignite2025
resource group

**Windows Plan --** Leave value populated by default

**Pricing Plan --** Premium V4 small

**Zone Redundancy --** disabled

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image30.png){width="5.833333333333333in"
height="5.922619203849519in"}

6.  On the **Advanced** tab provide following values and click
    **Deployment**

> **Storage Account --** select value from dropdown box starting with
> the name lab501
>
> **Container --** Select scriptcontainer
>
> **Zip File --** installcomponents.zip (Type the value. Since the
> storage account is locked down using User Managed Identity dropdown
> box will not be populated)
>
> **Value-** Read-only. Autogenerated
>
> **Identity -** select value from dropdown box starting with the name
> lab501
>
> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image31.png){width="6.499730971128609in"
> height="5.958333333333333in"}

7.  On the **Deployment** tab we will **not** make any changes and click
    **Networking**.

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image32.png){width="6.5in"
> height="7.898611111111111in"}

8.  On the **Networking** tab provide following values and click
    **Review**

> **Enable public access --** On
>
> **Enable virtual network integration --** On
>
> **Virtual network --** Select value from the dropdown box starting
> with the name Lab501
>
> **Enable VNet integration --** On
>
> **Outbound Subnet --** default2
>
> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image33.png){width="6.499889545056868in"
> height="6.511905074365704in"}

9.  On the **Review** tab click **Create.** Wait for the deployment to
    finish and click **Go to resource**

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image34.png){width="6.5in"
> height="6.996527777777778in"}
>
> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image35.png){width="6.5in"
> height="3.3270833333333334in"}

**Create Storage Adapters, Registry Adapter and Enable RDP using
Bastion**

1.  Navigate to the Managed Instance on App Service Plan we created
    above starting with the name ASP-

2.  Click on **Settings\>Configuration** in the left menu. You will see
    the General Settings tab with installation script details. Make no
    changes on this tab.

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image36.png){width="6.017857611548556in"
height="4.684027777777778in"}

3.  Click on **Mounts** tab and provide following values and click
    **Add**

**Name** -storage1

**Storage Type** -- Azure Files

**Storage Account** -- Select value from dropdown box starting with the
name lab501

**File Share** -- mountfs

**Vault -** Select value from dropdown box starting with the name lab501

**Secret -** Fileconnectionstring

**Mount drive letter --** K:\\mountfs

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image37.png){width="6.5in"
height="3.1319444444444446in"}

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image38.png){width="6.5in"
height="3.1222222222222222in"}

4.  Click on **Mounts** tab again and provide following values and click
    **Add**

**Name** -storage2

**Storage Type** -- Local

**Mount drive letter --** H

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image39.png){width="6.5in"
height="4.09523731408574in"}

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image40.png){width="6.5in"
height="5.924305555555556in"}

5.  Click on **Registry** tab. Provide following values and click
    **Add**

**Path** - HKEY_LOCAL_MACHINE/Software/Devshop/DBConnection

**Value** -- Select Key Vault from the dropdown box starting with the
name Lab501

**Secret** -Sqlconnectionstring

**Type** - String

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image41.png){width="6.5in"
height="5.038194444444445in"}

![A white background with black dots AI-generated content may be
incorrect.](/mediafolder/media/image42.png){width="7.273611111111111in"
height="5.357142388451444in"}

6.  Click on **Bastion/RDP** tab. Select the **Allow Remote Desktop (via
    Bastion)** check box and click **Apply**

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image43.png){width="6.5in"
height="4.736805555555556in"}

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image44.png){width="6.5in"
height="4.533333333333333in"}

**[Create Azure SQL Tables and Populate Sample Data]{.underline}**

1.  Open "Command Prompt" from the taskbar.

2.  Type cd C:\\Users\\Admin\\source\\ASMI_Scripts

3.  Type azsql.bat \<\<space\>\>**Username**\<\<space\>\>**Password**
    (not TAP). These values are available under **Resources** tab on the
    right navigation. Press **Enter.**

**\####** This batch script will perform Az Login. Create Azure SQL
Firewall rule to allow local Public IP. Create required SQL tables and
then populate these SQL tables with sample data.

![A computer screen with a black screen AI-generated content may be
incorrect.](/mediafolder/media/image45.png){width="6.5in"
height="3.3097222222222222in"}

**[Publish devShop Web App Code From Visual Studio 2026]{.underline}**

1.  Return to **Visual Studio 2026**.

2.  Right‑click **devShop** → **Publish**

3.  You will be guided to create **New** profile.

4.  Select **Azure** ![A screenshot of a computer AI-generated content
    may be incorrect.](/mediafolder/media/image46.png){width="6.5in"
    height="4.559722222222222in"}

5.  Select **Azure App Service (Windows).** Click Next

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image47.png){width="6.5in"
> height="4.559722222222222in"}

6.  Select the **App Service Web App** Created above. Click Finish.

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image48.png){width="6.5in"
> height="4.559722222222222in"}

7.  **Finish** → **Publish**.\
    ![A screenshot of a computer AI-generated content may be
    incorrect.](/mediafolder/media/image49.png){width="6.5in"
    height="4.247916666666667in"}

8.  Once publishing is complete **App Service Web App** will open in
    Microsoft edge browser.

9.  Click on any product name link on the home page of the **devShop**
    app

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image50.png){width="7.035714129483814in"
height="3.6069444444444443in"}

10. On the product details page click **Buy**

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image51.png){width="7.053571741032371in"
height="4.375in"}

11. Next screen displays purchase confirmation message.

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image52.png){width="6.839285870516186in"
height="3.75in"}

**[RDP into the Managed Instance on App Service Instance VM (using Azure
Bastion)]{.underline}**

In labs, **Azure Bastion** is pre‑provisioned within the **ignite2025**
resources group and to RDP into the App Service Plan instance follow the
steps mentioned below.

1.  In the App Service Plan portal experience click on **Instances** in
    the left-hand menu. You will see single instance for the App Service
    plan

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image53.png){width="6.5in"
> height="3.145138888888889in"}

2.  Click Connect. Azure Bastion will initiate remote login into the
    instance in a separate edge browser tab.

**\#### Allow pop‑ups for portal.azure.com before connecting.**

![A computer screen shot of a computer screen AI-generated content may
be incorrect.](/mediafolder/media/image54.png){width="6.5in"
height="3.59375in"}

**[Validate Adapters, Logs, and Installation Script on the App Service
Plan Instance]{.underline}**

Once you are remotely connected to the App Service Plan, instance using
Azure Bastion perform following tasks.

1.  Open **File Explorer**:

    - Confirm the **H:** (local) and **K:** (Azure Files) drives are
      present.

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image55.png){width="6.5in"
> height="3.803472222222222in"}

- Navigate to **H:\\temp\\logs** folder and opens **log.txt**. These
  logs are generated using log4net in the same destination file as the
  on-premises application.

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image56.png){width="6.5in"
> height="2.9611111111111112in"}

- Navigate to **k:\\mountfs** folder and review emails that are
  generated. These emails are generated using SMTP configuration we
  performed using the installation script. Thes emails are stored in the
  Azure file share named **mountfs** . You may navigate to Azure Storage
  account starting with the name starting with **lab501** within the
  **ignite2025** resource group.

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image57.png){width="6.5in"
> height="2.808333333333333in"}

2.  Open **IIS Manager (**In the search bar type **inetmgr** and open
    **IIS manager)**:

    - Inspect the site configuration (don't change settings).

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image58.png){width="6.5in"
> height="3.1951388888888888in"}

3.  Check Installation Script logs:

    - Navigate to **C:\\installscript\\script1** and open
      **install.txt** file to view logs.

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image59.png){width="6.5in"
height="5.788194444444445in"}

4.  Verify fonts installed:

    - Navigate to **C:\\Windows\\Fonts** and confirm new fonts are
      present.

> ![A screenshot of a computer AI-generated content may be
> incorrect.](/mediafolder/media/image60.png){width="6.5in"
> height="2.9652777777777777in"}

5.  Verify Registry Key creation by navigating to **regedit.exe**

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image61.png){width="6.5in"
height="5.757638888888889in"}

6.  Review **adapter logs** by navigating to
    **c:\\windows\\adapters.txt** log file.

![A screenshot of a computer AI-generated content may be
incorrect.](/mediafolder/media/image62.png){width="6.5in"
height="3.020138888888889in"}
