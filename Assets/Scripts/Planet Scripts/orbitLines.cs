using UnityEngine;
using System.Collections;

public class orbitLines : MonoBehaviour
{
    
    LineRenderer line;
    public int segments = 1000;

    // Use this for initialization
    void Start ()
    {
        MercuryOrbit();
        VenusOrbit();
        EarthOrbit();
        MarsOrbit();
        JupiterOrbit();
        SaturnOrbit();
        UranusOrbit();
        NeptuneOrbit();
        PlutoOrbit();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void MercuryOrbit()
    {
        line = GameObject.Find("MercuryOrbitLineRenderer").GetComponent<LineRenderer>();
        line.SetColors(Color.cyan, Color.cyan);
        line.material = new Material(Shader.Find("Particles/Additive"));

        line.SetVertexCount(segments + 1);
        line.useWorldSpace = false;

        float x = 0f;
        float y = 0f;
        float z = 0f;

        
        float xradius = 185.4f;
        float yradius = 185.4f;

    float angle = 2f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }

    void VenusOrbit()
    {
        line = GameObject.Find("VenusOrbitLineRenderer").GetComponent<LineRenderer>();
        line.SetColors(Color.cyan, Color.cyan);
        line.material = new Material(Shader.Find("Particles/Additive"));

        line.SetVertexCount(segments + 1);
        line.useWorldSpace = false;

        float x = 0f;
        float y = 0f;
        float z = 0f;


        float xradius = 285.92f;
        float yradius = 285.92f;

        float angle = 2f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }

    void EarthOrbit()
    {
        line = GameObject.Find("EarthOrbitLineRenderer").GetComponent<LineRenderer>();
        line.SetColors(Color.cyan, Color.cyan);
        line.material = new Material(Shader.Find("Particles/Additive"));

        line.SetVertexCount(segments + 1);
        line.useWorldSpace = false;

        float x = 0f;
        float y = 0f;
        float z = 0f;


        float xradius = 368.8f;
        float yradius = 368.8f;

        float angle = 2f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }

    void MarsOrbit()
    {
        line = GameObject.Find("MarsOrbitLineRenderer").GetComponent<LineRenderer>();
        line.SetColors(Color.cyan, Color.cyan);
        line.material = new Material(Shader.Find("Particles/Additive"));

        line.SetVertexCount(segments + 1);
        line.useWorldSpace = false;

        float x = 0f;
        float y = 0f;
        float z = 0f;


        float xradius = 525.4733f;
        float yradius = 525.4733f;

        float angle = 2f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }

    void JupiterOrbit()
    {
        line = GameObject.Find("JupiterOrbitLineRenderer").GetComponent<LineRenderer>();
        line.SetColors(Color.cyan, Color.cyan);
        line.material = new Material(Shader.Find("Particles/Additive"));

        line.SetVertexCount(segments + 1);
        line.useWorldSpace = false;

        float x = 0f;
        float y = 0f;
        float z = 0f;


        float xradius = 1626.338f;
        float yradius = 1626.338f;

        float angle = 2f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }

    void SaturnOrbit()
    {
        line = GameObject.Find("SaturnOrbitLineRenderer").GetComponent<LineRenderer>();
        line.SetColors(Color.cyan, Color.cyan);
        line.material = new Material(Shader.Find("Particles/Additive"));

        line.SetVertexCount(segments + 1);
        line.useWorldSpace = false;

        float x = 0f;
        float y = 0f;
        float z = 0f;


        float xradius = 2923.668f;
        float yradius = 2923.668f;

        float angle = 2f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }

    void UranusOrbit()
    {
        line = GameObject.Find("UranusOrbitLineRenderer").GetComponent<LineRenderer>();
        line.SetColors(Color.cyan, Color.cyan);
        line.material = new Material(Shader.Find("Particles/Additive"));

        line.SetVertexCount(segments + 1);
        line.useWorldSpace = false;

        float x = 0f;
        float y = 0f;
        float z = 0f;


        float xradius = 5810.917f;
        float yradius = 5810.917f;

        float angle = 2f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }

    void NeptuneOrbit()
    {
        line = GameObject.Find("NeptuneOrbitLineRenderer").GetComponent<LineRenderer>();
        line.SetColors(Color.cyan, Color.cyan);
        line.material = new Material(Shader.Find("Particles/Additive"));

        line.SetVertexCount(segments + 1);
        line.useWorldSpace = false;

        float x = 0f;
        float y = 0f;
        float z = 0f;


        float xradius = 9063.552f;
        float yradius = 9063.552f;

        float angle = 2f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }

    void PlutoOrbit()
    {
        line = GameObject.Find("PlutoOrbitLineRenderer").GetComponent<LineRenderer>();
        line.SetColors(Color.cyan, Color.cyan);
        line.material = new Material(Shader.Find("Particles/Additive"));

        line.SetVertexCount(segments + 1);
        line.useWorldSpace = false;

        float x = 0f;
        float y = 0f;
        float z = 0f;


        float xradius = 11889.6f;
        float yradius = 11889.6f;

        float angle = 2f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }
}
