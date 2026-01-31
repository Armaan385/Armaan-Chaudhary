import { motion } from "framer-motion";
import { Github, Linkedin, Mail, ArrowUpRight } from "lucide-react";

export default function Portfolio() {
  return (
    <main className="min-h-screen bg-white text-neutral-900 antialiased">
      {/* Hero */}
      <section className="max-w-4xl mx-auto px-6 pt-32 pb-24">
        <motion.h1
          initial={{ opacity: 0, y: 16 }}
          animate={{ opacity: 1, y: 0 }}
          transition={{ duration: 0.6 }}
          className="text-5xl md:text-6xl font-semibold tracking-tight"
        >
          Armaan Chaudhary
        </motion.h1>
        <p className="mt-6 text-xl text-neutral-600 max-w-2xl">
          Engineering student focused on Data Science, machine learning, and building
          clean, data-driven systems.
        </p>

        <div className="mt-10 flex items-center gap-6 text-sm">
          <a
            href="https://github.com/armaan385"
            target="_blank"
            className="flex items-center gap-2 hover:opacity-70 transition"
          >
            <Github size={18} /> GitHub <ArrowUpRight size={14} />
          </a>
          <a
            href="mailto:your@email.com"
            className="flex items-center gap-2 hover:opacity-70 transition"
          >
            <Mail size={18} /> Contact
          </a>
        </div>
      </section>

      {/* About */}
      <section className="max-w-4xl mx-auto px-6 pb-24">
        <h2 className="text-sm uppercase tracking-widest text-neutral-500 mb-6">
          About
        </h2>
        <p className="text-lg leading-relaxed text-neutral-700 max-w-3xl">
          I enjoy working at the intersection of data, software, and systems. My
          interests include exploratory data analysis, machine learning pipelines,
          and writing maintainable code with a strong focus on clarity and impact.
        </p>
      </section>

      {/* Skills */}
      <section className="max-w-4xl mx-auto px-6 pb-24">
        <h2 className="text-sm uppercase tracking-widest text-neutral-500 mb-6">
          Skills
        </h2>
        <div className="flex flex-wrap gap-3">
          {["Python", "Machine Learning", "Data Analysis", "SQL", "Pandas", "React", "Git"].map(
            (skill) => (
              <span
                key={skill}
                className="px-3 py-1.5 text-sm rounded-full border border-neutral-200"
              >
                {skill}
              </span>
            )
          )}
        </div>
      </section>

      {/* Projects */}
      <section className="max-w-4xl mx-auto px-6 pb-32">
        <h2 className="text-sm uppercase tracking-widest text-neutral-500 mb-10">
          Selected Projects
        </h2>

        <div className="space-y-12">
          <div className="group">
            <h3 className="text-2xl font-medium flex items-center gap-2">
              Data Analysis Toolkit
              <ArrowUpRight className="opacity-0 group-hover:opacity-100 transition" size={18} />
            </h3>
            <p className="mt-3 text-neutral-600 max-w-2xl">
              Exploratory data analysis and visualization workflows using Python,
              Pandas, and Matplotlib to extract actionable insights from raw data.
            </p>
            <a
              href="https://github.com/armaan385"
              target="_blank"
              className="inline-block mt-4 text-sm underline underline-offset-4"
            >
              View on GitHub
            </a>
          </div>

          <div className="group">
            <h3 className="text-2xl font-medium flex items-center gap-2">
              Machine Learning Models
              <ArrowUpRight className="opacity-0 group-hover:opacity-100 transition" size={18} />
            </h3>
            <p className="mt-3 text-neutral-600 max-w-2xl">
              Built and evaluated supervised learning models with a focus on
              performance, interpretability, and reproducibility.
            </p>
            <a
              href="https://github.com/armaan385"
              target="_blank"
              className="inline-block mt-4 text-sm underline underline-offset-4"
            >
              View on GitHub
            </a>
          </div>
        </div>
      </section>

      {/* Footer */}
      <footer className="border-t border-neutral-200">
        <div className="max-w-4xl mx-auto px-6 py-10 text-sm text-neutral-500 flex justify-between">
          <span>© {new Date().getFullYear()} Armaan Chaudhary</span>
          <span>India</span>
        </div>
      </footer>
    </main>
  );
}
